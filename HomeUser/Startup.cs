using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeUser.Startup))]
namespace HomeUser
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}


//git init
//git config --global user.name SanjivniRana

//git config --global user.email sanjivnirana@gmail.com
//git config --global credential.helper wincred
//git remote add origin https://github.com/SanjivniRana/notepad.git
//git push -u origin master

//git clone https://github.com/SanjivniRana/