using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerMenu.Helpers
{
    class ApiConfig
    {
        // Local
        //public static string BaseAdress { get; } = "http://192.168.0.8/wj_cliente/api/";

        //AWS 
        public static string BaseAdress { get; } = "http://ws.mobilivendas.com.br/wj_cliente/api/";
        public static string CallLevel { get; } = BaseAdress + "level";
        public static string CallLevelRelationship { get; } = BaseAdress + "level/relationship";
        public static string CallProducts { get; } = BaseAdress + "product";
        public static string CallProductsPhotos { get; } = BaseAdress + "product/photos";
        public static string CallProductsPhotosExtras { get; } = BaseAdress + "product/photosextras";
        public static string CallProductsSizes { get; } = BaseAdress + "product/sizes";
        public static string CallAccountAuthenticate { get; } = BaseAdress + "account/authenticate";
        public static string CallAccountBackGround { get; } = BaseAdress + "photosSystem";

        public static string CallPutCart { get; } = BaseAdress + "cart";
        public static string CallGetCart { get; } = BaseAdress + "cart/current";
        public static string CallGetCodCartCurrent { get; } = BaseAdress + "cart/getCodCartCurrent";
        public static string CallGetConditions { get; } = BaseAdress + "cart/getConditions";
        public static string CallGetSituations { get; } = BaseAdress + "cart/getSituations";
        public static string CallSaveCartCurrent { get; } = BaseAdress + "cart/saveCartCurrent";
        public static string CallGetCarts { get; } = BaseAdress + "cart/getCarts";
        public static string CallInformationCart { get; } = BaseAdress + "cart/getInformationCurrent";
        public static string CallCancelItemsCart { get; } = BaseAdress + "cart/cancelItems";
        public static string CallChangeSituationCart { get; } = BaseAdress + "cart/changeSituation";

        public static string CallBusinessTitles { get; } = BaseAdress + "business/getTitles";
        public static string CallBusinessItems { get; } = BaseAdress + "business/getItems";
        public static string CallBusinessCarts { get; } = BaseAdress + "business/getCarts";
        public static string CallBusinessSituationsTitles { get; } = BaseAdress + "business/getSituationsTitles";

        public static string ContentTypeJson { get; } = "application/json";
    }
}
