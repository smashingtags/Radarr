import PropTypes from 'prop-types';

function TranslatedMovieTitle({ movie, languageId }) {
  if (languageId === 0) {
    return movie.title;
  }

  const translatedTitle = movie.alternateTitles.find((c) => c.sourceType === 'translation' && c.language.id === languageId);

  if (translatedTitle) {
    return translatedTitle.title;
  }

  return movie.title;
}

TranslatedMovieTitle.propTypes = {
  movie: PropTypes.object.isRequired,
  languageId: PropTypes.number.isRequired
};

export default TranslatedMovieTitle;
