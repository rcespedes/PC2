using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WcfPC2
{

    [ServiceContract]
    public interface IRESTService
    {
                
        [OperationContract]
        [WebInvoke(UriTemplate = "/students/", Method = "POST")]
        Student CreateStudent(Student s);
        
        [OperationContract]
        [WebInvoke(UriTemplate = "/students/", Method = "GET")]
        List<Student> GetAllStudent();

        [OperationContract]
        [WebInvoke(UriTemplate = "/students/search/{query}", Method="GET")]
        Student GetQuery(string query);

        [OperationContract]
        [WebGet(UriTemplate = "/students/{id}")]
        Student GetAStudent(string id);

        [OperationContract]
        [WebInvoke(UriTemplate = "/students/{id}", Method = "PUT")]
        Student UpdateStudent(string id, Student s);

        [OperationContract]
        [WebInvoke(UriTemplate = "/students/{id}", Method = "DELETE")]
        void DeleteStudent(string id);
        
    }


    #region Entidad Estudiante
    [DataContract]
    public class Student
    {
        [DataMember]
        public string ID;
        [DataMember]
        public string birthdate;
        [DataMember]
        public string firstname;
        [DataMember]
        public string idbooster;
        [DataMember]
        public string lastname;

    }
    #endregion


}