using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concrete
{
    public class AboutManager
    {
        Repository<About> repoAbout = new Repository<About>();
        Repository<Admin> repoAdmin = new Repository<Admin>();
        public List<About> GetAll()
        {
            return repoAbout.List();
        }

        public List<Admin> GetAdmin()
        {
            return repoAdmin.List();
        }
        public int UpdateAdminBLL(Admin a)
        {
            Admin admin = repoAdmin.Find(x => x.AdminID == a.AdminID);
            admin.Username = a.Username;
            admin.Password = a.Password;
            return repoAdmin.Update(admin);
        }
        public int UpdateAboutBLL(About p)
        {
            About about = repoAbout.Find(x => x.AboutID == p.AboutID);
            about.AboutImage1 = p.AboutImage1;
            about.AboutContent1 = p.AboutContent1;
            about.AboutContent2 = p.AboutContent2;
            about.LinkedinLink = p.LinkedinLink;
            about.GithubLink = p.GithubLink;
            about.WebsiteLink = p.WebsiteLink;
            about.TwitterLink = p.TwitterLink;
            about.AboutID = p.AboutID;
            about.NameSurname = p.NameSurname;
            about.Job = p.Job;
            about.ProfilePhotoURL = p.ProfilePhotoURL;
            return repoAbout.Update(about);
        }
    }
}
