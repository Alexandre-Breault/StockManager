using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.WF.Model
{
    class ProductCategory
    {
        #region Attributes
        /// <summary>
        /// Identifiant de la catégorie
        /// </summary>
        private int _Identifier;
        /// <summary>
        /// Label de la catégorie
        /// </summary>
        private string _Label;

        #endregion
        /// <summary>
        /// Obtient ou défini l'identifiant d'une catégorie 
        /// </summary>
        public int Identifier
        {
            get { return _Identifier; }
            set { _Identifier = value; }
        }
        /// <summary>
        /// Obtient ou défini le label d'une catégorie
        /// </summary>
        public string Label
        {
            get { return _Label; }
            set { _Label = value; }
        }
        #region Properties

        #endregion
    }
}
