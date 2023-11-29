namespace clmodel
{
    public class UsuarioModel
    {
        private int _id;
        private string _user;
        private string _password;
        private string _email;
        private string _userType;

        public int Id { get => _id; set => _id = value; } 
        public string User { get => _user; set => _user = value; }
        public string Password { get => _password; set => _password = value; } 
        public string Email { get => _email; set => _email = value; }
        public string UserType { get => _userType; set => _userType = value; }
    }
}
