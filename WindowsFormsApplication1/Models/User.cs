﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReduOffline.Models
{
    public class User
    {

        public User()
        {
        }

        public User(String login, String first_name, List<Link> links, String email, String birthday, String last_name, int friends_count,
                        int id, String mobile, List<Thumbnail> thumbnails, List<Social_Network> social_networks, String localization, String birth_localization, String updated_at)
        {
            _login = login;
            _first_name = first_name;
            _links = links;
            _email = email;
            _birthday = birthday;
            _last_name = last_name;
            _friends_count = friends_count;
            _id = id;
            _mobile = mobile;
            _thumbnails = thumbnails;
            _social_networks = social_networks;
            _localization = localization;
            _birth_localization = birth_localization;
        }


        private String _login;
        private String _first_name;
        private List<Link> _links;
        private String _email;
        private String _birthday;
        private String _last_name;
        private int _friends_count;
        private int _id;
        private String _mobile;
        private List<Thumbnail> _thumbnails;
        private List<Social_Network> _social_networks;
        private String _localization;
        private String _birth_localization;
        private String _updated_at;
        private String _updated_at_local;
        private List<Enrollment> _enrollments;                

        public String Login 
        {
            get { return _login; }
            set { _login = value; }
        }

        public String First_Name
        {
            get { return _first_name; }
            set { _first_name = value; }
        }

        public List<Link> Links
        {
            get { return _links; }
            set { _links = value; }
        }

        public String Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public String Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }

        public String Last_Name
        {
            get { return _last_name; }
            set { _last_name = value; }
        }

        public int Friends_Count
        {
            get { return _friends_count; }
            set { _friends_count = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public String Mobile
        {
            get { return _mobile; }
            set { _mobile = value; }
        }

        public List<Thumbnail> Thumbnails
        {
            get { return _thumbnails; }
            set { _thumbnails = value; }
        }

        public List<Social_Network> Social_Networks
        {
            get { return _social_networks; }
            set { _social_networks = value; }
        }

        public String Localization
        {
            get { return _localization; }
            set { _localization = value; }
        }

        public String Birth_Localization
        {
            get { return _birth_localization; }
            set { _birth_localization = value; }
        }

        public String Updated_At
        {
            get { return _updated_at; }
            set { _updated_at = value; }
        }

        public List<Enrollment> Enrollments
        {
            get { return _enrollments; }
            set { _enrollments = value; }
        }

    }
}
