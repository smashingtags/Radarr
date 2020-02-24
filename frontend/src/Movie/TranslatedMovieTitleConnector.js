import { connect } from 'react-redux';
import { createSelector } from 'reselect';
import createMovieSelector from 'Store/Selectors/createMovieSelector';
import TranslatedMovieTitle from './TranslatedMovieTitle';

function createMapStateToProps() {
  return createSelector(
    createMovieSelector(),
    (state) => state.settings.ui.item.movieInfoLanguage,
    (movie, languageId) => {

      return {
        movie,
        languageId
      };
    }
  );
}

export default connect(createMapStateToProps)(TranslatedMovieTitle);
