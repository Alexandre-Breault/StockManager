using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.WF.Model
{
    public class StockMovement
    {
        #region Attributes
        /// <summary>
        /// identifiant du mouvement dans le stock
        /// </summary>
        private int _Identifier;

        /// <summary>
        /// Date du mouvement dans le stock
        /// </summary>
        private DateTime? _Date;

        /// <summary>
        /// Numéro de l'employé à l'origine du mouvement dans le stock
        /// </summary>
        private string _EmployeeCode;

        /// <summary>
        /// Entrée dans le stock
        /// </summary>
        private int _IsStockEntry;


        #endregion

        #region Properties
        /// <summary>
        /// Obtient ou défini l'identifiant du mouvement dans le stock
        /// </summary>
        public int Identifier
        {
            get { return _Identifier; }
            set { _Identifier = value; }
        }
        /// <summary>
        /// Obtient ou défini la date du mouvement dans le stock
        /// </summary>
        public DateTime? Date
        {
            get { return _Date; }
            set { _Date = value; }
        }
        /// <summary>
        /// Obtient ou défini Numéro de l'employé à l'origine du mouvement dans le stock
        /// </summary>
        public string EmployeeCode
        {
            get { return _EmployeeCode; }
            set { _EmployeeCode = value; }
        }
        /// <summary>
        /// Obtient ou défini l'entrée dans le stock
        /// </summary>
        public int IsStockEntry
        {
            get { return _IsStockEntry; }
            set { _IsStockEntry = value; }
        }

        #endregion
    }
}
