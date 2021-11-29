using System;
using System.ComponentModel.DataAnnotations;
using System.Web;
using Singular.Web;

namespace MEWeb.Movies
{
    public partial class Movies : MEPageBase<MoviesVM>
    {
    }

    public partial class TvShows : MEPageBase<MoviesVM>
    {
    }

    public partial class SportShows : MEPageBase<MoviesVM>
    {
    }

    public partial class KidsShows : MEPageBase<MoviesVM>
    {
    }
    public class MoviesVM : MEStatelessViewModel<MoviesVM>
    {
        public MELib.Movies.MovieList MovieList { get; set; }

 

        public MELib.Movies.UserMovieList UserMovieList { get; set; }

        public MELib.TvShows.TvShowList TVShowsList { get; set; }

        public MELib.SportShows.SportShowList SportShowsList { get; set; }

        public MELib.KidsShows.KidsShowList KidsShowsList { get; set; }

        // Filter Criteria
        public DateTime ReleaseFromDate { get; set; }
        public DateTime ReleaseToDate { get; set; }

        /// <summary>
        /// Gets or sets the Movie Genre ID
        /// </summary>
        [Singular.DataAnnotations.DropDownWeb(typeof(MELib.RO.ROMovieGenreList), UnselectedText = "Select", ValueMember = "MovieGenreID", DisplayMember = "Genre")]
        [Display(Name = "Genre")]
        public int? MovieGenreID { get; set; }

        public MoviesVM()
        {

        }
        protected override void Setup()
        {
            base.Setup();

            MovieList = MELib.Movies.MovieList.GetMovieList();
           // CartList = MELib.Carts.CartList.GetCartList();

            UserMovieList = MELib.Movies.UserMovieList.GetUserMovieList();

            TVShowsList = MELib.TvShows.TvShowList.GetTvShowList();

            SportShowsList = MELib.SportShows.SportShowList.GetSportShowList();

            KidsShowsList = MELib.KidsShows.KidsShowList.GetKidsShowList();

        }

        [WebCallable(LoggedInOnly = true)]
        public Result RentMovie(int MovieID)
        {
            Result sr = new Result();

            try
            {
               
                //var cart = MELib.Carts.Cart.NewCart();
              //  var movie = MELib.Movies.MovieList.GetMovieList(MovieID).FirstAndOnly();
                //cart.MovieID = movie.MovieID;
               // cart.SubTotal = movie.Price;
                //getting user Id
                // cart.UserID = Singular.Security.Security.CurrentIdentity.UserID;

                //Saving to UserMovie

               // MELib.Movies.UserMovieList

               // MELib.Movies.UserMovie UserMovie = new MELib.Movies.UserMovie();
                MELib.Movies.MovieList MovieList = MELib.Movies.MovieList.GetMovieList(MovieID);
                MELib.Movies.Movie Movie = MovieList.GetItem(MovieID);
                MELib.Movies.UserMovie UserMovie = MELib.Movies.UserMovie.NewUserMovie();

                UserMovie.MovieID = Movie.MovieID;
                UserMovie.UserID = Singular.Security.Security.CurrentIdentity.UserID;
             
               // UserMovie.IsActiveInd = true;
                //UserMovie.WatchedDate = DateTime.Now;

                //UserMovieList.Add(UserMovie);
                //UserMovieList.TrySave();
                var a = UserMovie.TrySave(typeof(MELib.Movies.UserMovieList));


                //cart.TrySave(typeof(MELib.Carts.CartList));

                sr.Success = true;
            }
            catch (Exception e)
            {
                sr.Data = e.InnerException;
                sr.Success = false;
            }
            return sr;

            //var url = $"../Movies/Movie.aspx?MovieId={HttpUtility.UrlEncode(Singular.Encryption.EncryptString(MovieID.ToString()))}";
            //return url;
        }


        //[WebCallable]
        //public string AddToCart(int CartID)
        //{
        //   // var url = $"../Movies/Movie.aspx?MovieId={HttpUtility.UrlEncode(Singular.Encryption.EncryptString(CartID.ToString()))}";
        //   // return url;
        //}



        [WebCallable]
        public static Result WatchMovie(int MovieID)
        {
            Result sr = new Result();
            try
            {

                // ToDo Check User Balance
                // ToDo Insert Data in Transctions

                sr.Success = true;
            }
            catch (Exception e)
            {
                sr.Data = e.InnerException;
                sr.Success = false;
            }
            return sr;
        }

        [WebCallable]
        public Result FilterMovies(int MovieGenreID)
        {
            Result sr = new Result();
            Result sr1 = new Result();

            Result sr2 = new Result();

            Result sr3 = new Result();

            try
            {
                sr.Data = MELib.Movies.MovieList.GetMovieList(MovieGenreID);
                sr.Success = true;

                sr1.Data = MELib.TvShows.TvShowList.GetTvShowList();
                sr1.Success = true;

                sr2.Data = MELib.SportShows.SportShowList.GetSportShowList();
                sr2.Success = true;

                sr3.Data = MELib.KidsShows.KidsShowList.GetKidsShowList();
                sr3.Success = true;


            }
            catch (Exception e)
            {
                WebError.LogError(e, "Page: LatestReleases.aspx | Method: FilterMovies", $"(int MovieGenreID, ({MovieGenreID})");
                sr.Data = e.InnerException;
                sr.ErrorText = "Could not filter movies by category.";
                sr.Success = false;
            }
            return sr;
        }

        public Result FilterTvShows(int MovieGenreID)
        {
            Result sr = new Result();
            Result sr1 = new Result();

            Result sr2 = new Result();

            Result sr3 = new Result();

            try
            {


                sr1.Data = MELib.TvShows.TvShowList.GetTvShowList();
                sr1.Success = true;

            }
            catch (Exception e)
            {
                WebError.LogError(e, "Page: LatestReleases.aspx | Method: FilterMovies", $"(int MovieGenreID, ({MovieGenreID})");
                sr1.Data = e.InnerException;
                sr1.ErrorText = "Could not filter movies by category.";
                sr1.Success = false;
            }
            return sr1;
        }

    }


}

