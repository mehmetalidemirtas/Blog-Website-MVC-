﻿using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concrete
{
    public class CommentManager
    {
        Repository<Comment> repoComment = new Repository<Comment>();
        public List<Comment> CommentList()
        {
            return repoComment.List();
        }
        public List<Comment> CommentByStatusTrue()
        {
            return repoComment.List(x=>x.CommentStatus==true);
        }
        public List<Comment> CommentByStatusFalse()
        {
            return repoComment.List(x => x.CommentStatus == false);
        }
        public List<Comment> CommentByBlog(int id)
        {
            return repoComment.List(x => x.BlogID == id);
        }
        public int CommentAdd(Comment c)
        {
            if(c.CommentText.Length>=1000 || c.NameSurname=="" || c.Mail=="")
            {
                return -1;
            }
            return repoComment.Insert(c);
        }
        public int StatusChangeToFalseBLL(int id)
        {
            Comment comment = repoComment.Find(x => x.CommentID == id);
            comment.CommentStatus = false;
            return repoComment.Update(comment);
        }
        public int StatusChangeToTrueBLL(int id)
        {
            Comment comment = repoComment.Find(x => x.CommentID == id);
            comment.CommentStatus = true;
            return repoComment.Update(comment);
        }
        public int DeleteCommentBLL(int p)
        {
            Comment comment = repoComment.Find(x => x.CommentID == p);
            return repoComment.Delete(comment);
        }
    }
}
