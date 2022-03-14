using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labArch
{
    public class RegistrationPresenter : IPresenter
    {
        private readonly IRegistrationModel _dataBaseMapper;
        private readonly IRegistrationView _registrationForm;
        public RegistrationPresenter(IRegistrationModel dataBaseMapper, IRegistrationView registrationForm)
        {
            _dataBaseMapper = dataBaseMapper;
            _registrationForm = registrationForm;
            _registrationForm.Registration += () => Registration(_registrationForm.Token,_registrationForm.FullName,
            _registrationForm.Rank,_registrationForm.Position,_registrationForm.Password,_registrationForm.RePassword);
        }
        public void Run()
        {
            _registrationForm.Show();
        }
        private void Registration(int idToken, string fullName, string rank, string position, string password, string rePassword)
        {
            try
            {
                if (idToken <= 0 || string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(rank) || string.IsNullOrEmpty(position))
                {
                    throw new Exception("Не введены все данные");
                }
                Policeman policeman = new Policeman(idToken, fullName, rank, position);
                if (!password.Equals(rePassword))
                {
                    throw new Exception("Пароли не совпадают");
                }
                _dataBaseMapper.Insert(policeman, password);
                _registrationForm.ShowError("Регистрация успешна");
            }
            catch(Exception ex)
            {
                _registrationForm.ShowError(ex.Message);
            }
        }
    }
}
