using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labArch
{
   public class LoginPresenter:IPresenter
    {
        private readonly ILoginModel _dataBaseMapper;
        private readonly ILoginView _loginForm;

        public LoginPresenter(ILoginModel dataBaseMapper, ILoginView loginForm)
        {
            _dataBaseMapper = dataBaseMapper;
            _loginForm = loginForm;
            _loginForm.Login += () => Login(_loginForm.Token, _loginForm.Password);
            _loginForm.Registration +=  Regestration;
        }

        public void Run()
        {
            _loginForm.Show();
        }

        private void Login(int token, string password)
        {
            Policeman policeman=null;
            try
            {
                if (token <= 0)
                {
                    throw new Exception("Не введен номер жетона");
                }
                if (password == null)
                {
                    throw new ArgumentNullException("Не введен пароль");
                }
                 policeman = _dataBaseMapper.Select(token, password);
            }catch(Exception ex)
            {
                _loginForm.ShowError(ex.Message);
                return;
            }
            InspectionPresenter inspection = new InspectionPresenter(new InspectionForm(), new CarMapper("PoliceDB"), new DriverMapper("PoliceDB"), policeman);
            inspection.Run();
        }
        private void Regestration()
        {
            RegistrationPresenter registration= new RegistrationPresenter(new PolicemanMapper("PoliceDB"), new RegistrationForm());
            registration.Run();
        }
    }
}
