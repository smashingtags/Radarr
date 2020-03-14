using FluentMigrator;
using NzbDrone.Core.Datastore.Migration.Framework;

namespace NzbDrone.Core.Datastore.Migration
{
    [Migration(173)]
    public class language_improvements : NzbDroneMigrationBase
    {
        protected override void MainDbUpgrade()
        {
            // Use original language to set default language fallback for releases
            Alter.Table("Movies").AddColumn("OriginalLanguage").AsString().Nullable();

            // Add for future
            Alter.Table("Movies").AddColumn("SpokenLanguages").AsString().WithDefaultValue("[]");

            // Should only throw unique if same movie, same language, same title
            // We don't want to prevent translations from being added
            Execute.Sql("DROP INDEX IF EXISTS \"IX_AlternativeTitles_CleanTitle\"");

            // Execute.Sql("CREATE TABLE alttitles(titleId TEXT, MovieId INTEGER, CleanTitle TEXT, Language INTEGER, UNIQUE(MovieId,CleanTitle,Language))");
            // Delete.UniqueConstraint().FromTable("AlternativeTitles").Column("CleanTitle");
            // Create.UniqueConstraint("MovieIdTitleLanguage").OnTable("AlternativeTitles").Columns(new string[] { "MovieId", "CleanTitle", "Language" });
        }
    }
}
