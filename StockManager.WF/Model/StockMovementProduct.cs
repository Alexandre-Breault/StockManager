using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.WF.Model
{
    class StockMovementProduct
    {
        #region Attributes
        /// <summary>
        /// Identifiant d'un mouvement d'un produit
        /// </summary>
        private int _Identifier;
        /// <summary>
        /// Identifiant d'un produit
        /// </summary>
        private Product _IdentifierProduct;
        /// <summary>
        /// Identifiant d'un mouvement dans le stock
        /// </summary>
        private StockMovement _IdentifierStockMovement;
        /// <summary>
        /// Quantité d'un produit dans le stock
        /// </summary>
        private decimal _Quantity;
        #endregion

        #region Properties
        /// <summary>
        /// Obtient ou défini l'identifiant d'un mouvement d'un produit
        /// </summary>
        public int Identifier
        {
            get { return _Identifier; }
            set { _Identifier = value; }
        }
        /// <summary>
        /// Obtient ou défini l'identifiant d'un produit
        /// </summary>
        public Product IdentifierProduct
        {
            get { return _IdentifierProduct; }
            set { _IdentifierProduct = value; }
        }
        /// <summary>
        /// Obtient ou défini l'identifiant d'un mouvement dans le stock
        /// </summary>
        public StockMovement IdentifierStockMovement
        {
            get { return _IdentifierStockMovement; }
            set { _IdentifierStockMovement = value; }
        }
        /// <summary>
        /// Obtient ou défini la quantité d'un produit dans le stock
        /// </summary>
        public decimal Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }
        #endregion
    }
}
