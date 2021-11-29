using System;
using Singular.CommonData;

namespace MELib
{
  public class CommonData : CommonDataBase<MELib.CommonData.MECachedLists>
  {
    [Serializable]
    public class MECachedLists : CommonDataBase<MECachedLists>.CachedLists
    {
      /// <summary>
      /// Gets cached ROUserList
      /// </summary>
      public MELib.RO.ROUserList ROUserList
      {
        get
        {
          return RegisterList<MELib.RO.ROUserList>(Misc.ContextType.Application, c => c.ROUserList, () => { return MELib.RO.ROUserList.GetROUserList(); });
        }
            }

            public RO.ROMovieGenreList ROMovieGenreList
            {
                get
                {
                    return RegisterList<MELib.RO.ROMovieGenreList>(Misc.ContextType.Application, c => c.ROMovieGenreList, () => { return MELib.RO.ROMovieGenreList.GetROMovieGenreList(); });
                }
            }
            //SnackTypeList
            public Snacks.SnackTypeList SnackTypeList
            {
                get{
                    return RegisterList<MELib.Snacks.SnackTypeList>(Misc.ContextType.Application, c => c.SnackTypeList, () => { return MELib.Snacks.SnackTypeList.GetSnackTypeList(); });

                } }

            public Basket.DeliveryList DeliveryList
            {
                get
                {
                    return RegisterList<MELib.Basket.DeliveryList>(Misc.ContextType.Application, c => c.DeliveryList, () => { return MELib.Basket.DeliveryList.GetDeliveryList(); });

                }
            }

        }
  }

  public class Enums
  {
		public enum AuditedInd
		{
			Yes = 1,
			No = 0
		}
    public enum DeletedInd
    {
      Yes = 1,
      No = 0
    }
  }
}
