using System.Collections.Generic;

namespace NzbDrone.Core.MetadataSource.SkyHook.Resource
{
    public class FindRootResource
    {
        public MovieResultResource[] Movie_results { get; set; }
    }

    public class MovieSearchRootResource
    {
        public int Page { get; set; }
        public MovieResultResource[] Results { get; set; }
        public int Total_results { get; set; }
        public int Total_pages { get; set; }
    }

    public class AuthRefreshTokenResponse
    {
        public string Request_token { get; set; }
    }

    public class AuthAccessTokenResponse
    {
        public string Access_token { get; set; }
        public string Account_id { get; set; }
    }

    public class MovieResultResource
    {
        public string Poster_path { get; set; }
        public bool Adult { get; set; }
        public string Overview { get; set; }
        public string Release_date { get; set; }
        public int?[] Genre_ids { get; set; }
        public int Id { get; set; }
        public string Original_title { get; set; }
        public string Original_language { get; set; }
        public string Title { get; set; }
        public string Backdrop_path { get; set; }
        public float Popularity { get; set; }
        public int Vote_count { get; set; }
        public bool Video { get; set; }
        public float Vote_average { get; set; }
        public string Trailer_key { get; set; }
        public string Trailer_site { get; set; }
        public string Physical_release { get; set; }
        public string Physical_release_note { get; set; }
    }

    public class CreditsResultResource : MovieResultResource
    {
        public string Department { get; set; }
        public string Job { get; set; }
        public string Credit_id { get; set; }
    }

    public class MovieResourceRoot
    {
        public bool Adult { get; set; }
        public string Backdrop_path { get; set; }
        public CollectionResource Belongs_to_collection { get; set; }
        public int? Status_code { get; set; }
        public string Status_message { get; set; }
        public int Budget { get; set; }
        public GenreResource[] Genres { get; set; }
        public string Homepage { get; set; }
        public int Id { get; set; }
        public string Imdb_id { get; set; }
        public string Original_language { get; set; }
        public string Original_title { get; set; }
        public string Overview { get; set; }
        public float Popularity { get; set; }
        public string Poster_path { get; set; }
        public ProductionCompaniesResource[] Production_companies { get; set; }
        public ProductionCountriesResource[] Production_countries { get; set; }
        public string Release_date { get; set; }
        public long Revenue { get; set; }
        public int Runtime { get; set; }
        public SpokenLanguagesResource[] Spoken_languages { get; set; }
        public string Status { get; set; }
        public string Tagline { get; set; }
        public string Title { get; set; }
        public bool Video { get; set; }
        public float Vote_average { get; set; }
        public int Vote_count { get; set; }
        public AlternativeTitlesResource Alternative_titles { get; set; }
        public ReleaseDatesResource Release_dates { get; set; }
        public VideosResource Videos { get; set; }
        public CreditsResource Credits { get; set; }
        public TranslationsResource Translations { get; set; }
    }

    public class ReleaseDatesResource
    {
        public List<ReleaseDatesLanguageResource> Results { get; set; }
    }

    public class CreditsResource
    {
        public List<CastResource> Cast { get; set; }
        public List<CrewResource> Crew { get; set; }
    }

    public class ReleaseDateResource
    {
        public string Certification { get; set; }
        public string Iso_639_1 { get; set; }
        public string Note { get; set; }
        public string Release_date { get; set; }
        public int Type { get; set; }
    }

    public class ReleaseDatesLanguageResource
    {
        public string Iso_3166_1 { get; set; }
        public List<ReleaseDateResource> Release_dates { get; set; }
    }

    public class CollectionResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Poster_path { get; set; }
        public string Backdrop_path { get; set; }
    }

    public class GenreResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ProductionCompaniesResource
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }

    public class ProductionCountriesResource
    {
        public string Iso_3166_1 { get; set; }
        public string Name { get; set; }
    }

    public class SpokenLanguagesResource
    {
        public string Iso_639_1 { get; set; }
        public string Name { get; set; }
    }

    public class AlternativeTitlesResource
    {
        public List<TitleResource> Titles { get; set; }
    }

    public class TitleResource
    {
        public string Iso_3166_1 { get; set; }
        public string Title { get; set; }
    }

    public class VideosResource
    {
        public List<VideoResource> Results { get; set; }
    }

    public class CrewResource
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string Job { get; set; }
        public string Credit_Id { get; set; }
        public int Id { get; set; }
        public string Profile_Path { get; set; }
    }

    public class CastResource
    {
        public string Name { get; set; }
        public string Character { get; set; }
        public string Credit_Id { get; set; }
        public int Id { get; set; }
        public int Order { get; set; }
        public string Profile_Path { get; set; }
    }

    public class VideoResource
    {
        public string Id { get; set; }
        public string Iso_639_1 { get; set; }
        public string Iso_3166_1 { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public string Site { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }
    }

    public class TranslationsResource
    {
        public List<TranslationResource> Translations { get; set; }
    }

    public class TranslationResource
    {
        public string Iso_639_1 { get; set; }
        public string Iso_3166_1 { get; set; }
        public string Name { get; set; }
        public string English_name { get; set; }
        public TranslationDataResource Data { get; set; }
    }

    public class TranslationDataResource
    {
        public string Title { get; set; }
        public string Overview { get; set; }
    }

    public class ListResponseRootResource
    {
        public string Id { get; set; }
        public ListItemResource[] Results { get; set; }
        public int Total_results { get; set; }
        public string Iso_639_1 { get; set; }
        public string Name { get; set; }
        public object Poster_path { get; set; }
    }

    public class CollectionResponseRootResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Overview { get; set; }
        public string Poster_path { get; set; }
        public string Backdrop_path { get; set; }
        public MovieResultResource[] Parts { get; set; }
    }

    public class PersonCreditsRootResource
    {
        public CreditsResultResource[] Cast { get; set; }
        public CreditsResultResource[] Crew { get; set; }
        public int Id { get; set; }
    }

    public class ListItemResource : MovieResultResource
    {
        public string Media_type { get; set; }
        public string First_air_date { get; set; }
        public string[] Origin_country { get; set; }
        public string Name { get; set; }
        public string Original_name { get; set; }
    }
}
