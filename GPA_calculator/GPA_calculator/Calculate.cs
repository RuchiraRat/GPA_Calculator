using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GPA_calculator
{
    public class Calculate
    {
        private string sub1grade;
        private string sub2grade;
        private string sub3grade;
        private string sub4grade;
        private string sub5grade;
        private string sub6grade;
        private string sub7grade;
        private string sub8grade;
        private string sub9grade;
        private string sub10grade;
        private string sub11grade;
        private string sub12grade;
        private string sub13grade;
        private int credittot;

        public string Sub1grade
        {
            get { return sub1grade; }
            set { sub1grade = value; }
        }
        public string Sub2grade
        {
            get { return sub2grade; }
            set { sub2grade = value; }
        }
        public string Sub3grade
        {
            get { return sub3grade; }
            set { sub3grade = value; }
        }
        public string Sub4grade
        {
            get { return sub4grade; }
            set { sub4grade = value; }
        }
        public string Sub5grade
        {
            get { return sub5grade; }
            set { sub5grade = value; }
        }
        public string Sub6grade
        {
            get { return sub6grade; }
            set { sub6grade = value; }
        }
        public string Sub7grade
        {
            get { return sub7grade; }
            set { sub7grade = value; }
        }
        public string Sub8grade
        {
            get { return sub8grade; }
            set { sub8grade = value; }
        }
        public string Sub9grade
        {
            get { return sub9grade; }
            set { sub9grade = value; }
        }
        public string Sub10grade
        {
            get { return sub10grade; }
            set { sub10grade = value; }
        }
        public string Sub11grade
        {
            get { return sub11grade; }
            set { sub11grade = value; }
        }
        public string Sub12grade
        {
            get { return sub12grade; }
            set { sub12grade = value; }
        }
        public string Sub13grade
        {
            get { return sub13grade; }
            set { sub13grade = value; }
        }
        public int Credittot
        {
            get { return credittot; }
            set { credittot = value; }
        }

        public int sub1credit = 3;
        public int sub2credit = 3;
        public int sub3credit = 3;
        public int sub4credit = 4;
        public int sub5credit = 2;
        public int sub6credit = 4;
        public int sub7credit = 3;
        public int sub8credit = 4;
        public int sub9credit = 4;
        public int sub10credit = 4;
        public int sub11credit = 4;
        public int sub12credit = 4;
        public int sub13credit = 3;

        public double subgpa (string subgrade)
        {
            double subgp = 0;

            if (subgrade == "A+")
            {
                subgp = 4.0;
            }
            else if (subgrade == "A")
            {
                subgp = 4.0;
            }
            else if (subgrade == "A-")
            {
                subgp = 3.7;
            }
            else if (subgrade == "B+")
            {
                subgp = 3.3;
            }
            else if (subgrade == "B")
            {
                subgp = 3.0;
            }
            else if (subgrade == "B-")
            {
                subgp = 2.7;
            }
            else if (subgrade == "C+")
            {
                subgp = 2.3;
            }
            else if (subgrade == "C")
            {
                subgp = 2.0;
            }
            else if (subgrade == "C-")
            {
                subgp = 1.7;
            }
            else if (subgrade == "D+")
            {
                subgp = 1.3;
            }
            else if (subgrade == "D")
            {
                subgp = 1.0;
            }
            else if (subgrade == "E")
            {
                subgp = 0.0;
            }
            else
            {
                subgp = 0;
            }

            return subgp;
        }

        public double gpa()
        {
            double gpa = 0;

            double sub1gp = subgpa(sub1grade) * sub1credit;
            double sub2gp = subgpa(sub2grade) * sub2credit;
            double sub3gp = subgpa(sub3grade) * sub3credit;
            double sub4gp = subgpa(sub4grade) * sub4credit;
            double sub5gp = subgpa(sub5grade) * sub5credit;
            double sub6gp = subgpa(sub6grade) * sub6credit;
            double sub7gp = subgpa(sub7grade) * sub7credit;
            double sub8gp = subgpa(sub8grade) * sub8credit;
            double sub9gp = subgpa(sub9grade) * sub9credit;
            double sub10gp = subgpa(sub10grade) * sub10credit;
            double sub11gp = subgpa(sub11grade) * sub11credit;
            double sub12gp = subgpa(sub12grade) * sub12credit;
            double sub13gp = subgpa(sub13grade) * sub13credit;

            gpa = (sub1gp + sub2gp + sub3gp + sub4gp + sub5gp + sub6gp + sub7gp + sub8gp + sub9gp + sub10gp + sub11gp + sub12gp + sub13gp)/credittot;

            return gpa;
        }
    }
}
