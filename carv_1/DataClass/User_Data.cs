using ModelsClass.Common;
using ModelsClass.MethodParameters;
using ModelsClass.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataClass
{
    public class User_Data
    {
        private AppContext _context;

        public User_Data()
        {
            _context = new AppContext();
        }
        public BaseOut CreateUser(CreateUser input)
        {
            BaseOut output = new BaseOut() { Result = Result.error };
            try
            {
                var userInDb = _context.Users.SingleOrDefault(m => m.IdNumber == input.IdNumber || m.Email == input.Email);
                if (userInDb == null)
                {
                    var a = _context.Users.Add(new User()
                    {
                        Email = input.Email,
                        IdNumber = input.IdNumber,
                        IdType = input.IdType,
                        Name = input.Name,
                        PassWord = SerializePass(Encoding.UTF8.GetBytes(input.PassWord)),
                        Surname = "Apellido1"
                    });
                    _context.SaveChanges();

                    output.Result = Result.success;
                }
                else
                {
                    output.Message = "Usuario ya existe en la base de datos";
                    output.Result = Result.alreadyExist;
                }

            }
            catch (Exception ex)
            {
                output.Message = ex.Message;
                throw ex;
            }
            return output;
        }

        public UserLoginOut Login(UserLoginIn input)
        {
            UserLoginOut output = new UserLoginOut() { Result = Result.error, usrLoggued = false};
            try
            {
                var userInDb = _context.Users.SingleOrDefault(m => m.IdNumber == input.IdNumber);
                if(userInDb != null)
                {
                    var usr_passEnc = SerializePass(Encoding.UTF8.GetBytes(input.PassWord));
                    if (usr_passEnc == userInDb.PassWord)
                    {
                        output.Result = Result.success;
                        output.usrLoggued = true;
                    }
                    else
                    {
                        output.Message = "Usuario o contraseña incorrecta";
                    }
                }
                else
                {
                    output.Result = Result.notFound;
                    output.Message = "Usuario o contraseña incorrecta";
                }
                

            }
            catch (Exception ex)
            {
                output.Message = ex.Message;
            }


            return output;
        }

        private string SerializePass(byte[] passIn)
        {
            string res = "";
            foreach (var t in passIn)
            {
                res += t.ToString();
            }
            return res;
        }


    }
}
