using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.WF.Model
{
    public class Product
    {
        #region Attributes
        /// <summary>
        /// identifiant du produit
        /// </summary>
        private int _Identifier;
        /// <summary>
        /// nom du produit
        /// </summary>
        private string _NameProduct;
        /// <summary>
        /// Référence du Produit
        /// </summary>
        private string _ReferenceProduct;
        /// <summary>
        /// Prix du produit
        /// </summary>
        private decimal _PriceProduct;
        /// <summary>
        /// Description du produit
        /// </summary>
        private string _DescriptionProduct;
        /// <summary>
        /// Identifiant de la catégorie du produit
        /// </summary>
        private ProductCategory _IdentifierProductCategory;
        /// <summary>
        /// Quantité du produit
        /// </summary>
        private decimal _StoredQuantity;
        #endregion

        #region Properties
        /// <summary>
        /// Obtient ou défini l'identifiant d'un produit
        /// </summary>
        public int Identifier
        {
            get { return _Identifier; }
            set { _Identifier = value; }
        }
        /// <summary>
        /// Obtient ou défini le nom d'un produit
        /// </summary>
        public string NameProduct
        {
            get { return _NameProduct; }
            set { _NameProduct = value; }
        }
        /// <summary>
        /// Obtient ou défini la référence d'un produit
        /// </summary>
        public string ReferenceProduct
        {
            get { return _ReferenceProduct; }
            set { _ReferenceProduct = value; }
        }
        /// <summary>
        /// Obtient ou défini le prix d'un produit
        /// </summary>
        public decimal PriceProduct
        {
            get { return _PriceProduct; }
            set { _PriceProduct = value; }
        }
        /// <summary>
        /// Obtient ou défini la desciption d'un produit
        /// </summary>
        public string DescriptionProduct
        {
            get { return _DescriptionProduct; }
            set { _DescriptionProduct = value; }
        }
        /// <summary>
        /// Obtient ou défini la desciption d'un produit
        /// </summary>
        public ProductCategory IdentifierProductCategory
        {
            get { return _IdentifierProductCategory; }
            set { _IdentifierProductCategory = value; }
        }
        /// <summary>
        /// Obtient ou défini la quantité d'un produit
        /// </summary>
        public decimal StoredQuantity
        {
            get { return _StoredQuantity; }
            set { _StoredQuantity = value; }
        }
        #endregion
    }
}
