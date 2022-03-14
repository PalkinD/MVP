using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labArch
{
  public  class Policeman
    {
        private int _idToken;
        private string _fullName;
        private string _rank;
        private string _position;
        public Policeman()
        {
            _idToken = 0;
        }
        public Policeman(int idToken,string fullName,string rank,string position)
        {
                _idToken = idToken;
                _fullName = fullName;
                _rank = rank;
                _position = position;
        }
        public int IdToken { get => _idToken; }
        public string FullName { get => _fullName; }
        public string Rank { get => _rank; }
        public string Position{ get => _position; }
    }
}
