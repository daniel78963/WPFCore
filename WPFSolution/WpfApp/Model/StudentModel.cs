using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace WpfApp.Model
{
    public class StudentModel
    {
        //La clase base ‘INotifyPropertyChanged‘ notifica que el valor de una propiedad ha cambiado,
        //genera un evento PropertyChanged cuando cambia el valor de un miembro de la clase.Debemos
        //definir un atributo de tipo PropertyChangedEventHandler como manejador del evento para
        //notificar a las clases cuando cambia una propiedad en alguno de los atributos editables (firstName, lastName).

        //Los atributos privados de la clase son el nombre y apellido, controlamos el acceso a sus
        //propiedades con los descriptores de acceso get/set (ver más sobre este tema en «C# class
        //LibroCalificaciones: Acceso a propiedades con descriptores de acceso get / set«), de esta
        //forma controlamos cuando cambia el valor y lanzamos la función RaisePropertyChanged que a
        //su vez llama a al manejador PropertyChanged. El resto de código y comprobaciones que realiza
        //con fáciles de comprender. Si por ejemplo cambia el nombre genera un evento adicional para
        //que en coherencia cambie el FullName.

        public class Student : INotifyPropertyChanged
        {
            private string firstName;
            private string lastName;

            public string FirstName
            {
                get
                {
                    return firstName;
                }

                set
                {
                    if (firstName != value)
                    {
                        firstName = value;
                        RaisePropertyChanged("FirstName");
                        RaisePropertyChanged("FullName");
                    }
                }
            }

            public string LastName
            {
                get { return lastName; }

                set
                {
                    if (lastName != value)
                    {
                        lastName = value;
                        RaisePropertyChanged("LastName");
                        RaisePropertyChanged("FullName");
                    }
                }
            }

            public string FullName
            {
                get
                {
                    return firstName + " " + lastName;
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;

            private void RaisePropertyChanged(string property)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(property));
                }
            }
        }
    }
}
