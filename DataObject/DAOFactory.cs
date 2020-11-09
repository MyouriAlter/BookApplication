using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObject
{
    // Factory of factories. This class is a factory class that creates
    // data-base specific factories which in turn create data acces objects.
    // ** GoF Design Patterns: Factory.

    public class DAOFactory
    {
        // gets a provider specific (i.e. database specific) factory 

        // ** GoF Design Pattern: Factory

        public static IDAOFactory GetFactory()
        {
            // return the requested DaoFactory

            return new AdoNet.DAOFactory();
        }
    }
}
