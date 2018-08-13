using MyIocTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyIocTest.Controllers
{
    public class MeScrollController : Controller
    {
        // GET: MeScroll
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetListData(int page_num, int page_size)
        {
            List<Book> books = new List<Book>();
            if (page_num > 2)
            {
                page_size = 5;
            }

            for (int i = 0; i < page_size; i++)
            {
                int index = (page_num - 1) * page_size + i + 1;
                Book book = new Book() { title = "我的title" + index, content = "我的内容" + index };
                books.Add(book);
            }

            //Book book1 = new Book() { title = "我的title1", content = "我的内容1" };
            //Book book2 = new Book() { title = "我的title2", content = "我的内容2" };
            //Book book3 = new Book() { title = "我的title2", content = "我的内容2" };
            //Book book4 = new Book() { title = "我的title2", content = "我的内容2" };
            //Book book5 = new Book() { title = "我的title2", content = "我的内容2" };
            //Book book6 = new Book() { title = "我的title2", content = "我的内容2" };
            //books.Add(book1);
            //books.Add(book2);
            //books.Add(book3);
            //books.Add(book4);
            //books.Add(book5);
            //books.Add(book6);
            return Json(books, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Tabs()
        {
            return View();
        }
    }
}