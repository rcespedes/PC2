using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel.Activation;
using System.ServiceModel;


namespace WcfPC2
{

    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class RESTService : IRESTService
    {

        List<Student> objStudent = new List<Student>();
        int studentCount = 0;
                       
        public Student CreateStudent(Student s)
        {
            s.ID = (++studentCount).ToString();
            objStudent.Add(s);
            return s;
        }

        public List<Student> GetAllStudent()
        {
            return objStudent.ToList();
        }

        public Student GetQuery(string query)
        {
            return objStudent.FirstOrDefault(e => e.firstname.Equals(query));
        }

        public Student GetAStudent(string id)
        {
            return objStudent.FirstOrDefault(e => e.ID.Equals(id));
        }

        public Student UpdateStudent(string id, Student s)
        {
            Student p = objStudent.FirstOrDefault(e => e.ID.Equals(id));
            p.birthdate = s.birthdate;
            p.firstname = s.firstname;
            p.lastname = s.lastname;
            p.idbooster = s.idbooster;
            return p;
        }

        public void DeleteStudent(string id)
        {
            objStudent.RemoveAll(e => e.ID.Equals(id));
        }
    }




}