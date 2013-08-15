﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReduOffline.Models
{
    public class Space
    {

        public Space() { }

        private String _id;
        private String _name;
        private String _description;
        private String _created_at;
        private List<Link> _links;
        private List<Subject> _subjects;
        private List<Status> _timeline;
        private Course _parent_course;

        public Course Parent_Course
        {
            get { return _parent_course; }
            set { _parent_course = value; }
        }

        public String Id
        {
            get { return _id; }
            set { _id = value; }
        }
        
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }
        
        public String Created_at
        {
            get { return _created_at; }
            set { _created_at = value; }
        }
        
        public List<Link> Links
        {
            get { return _links; }
            set { _links = value; }
        }
        
        public List<Subject> Subjects
        {
            get { return _subjects; }
            set { _subjects = value; }
        }

        public List<Status> Timeline
        {
            get { return _timeline; }
            set { _timeline = value; }
        }
    }
}
