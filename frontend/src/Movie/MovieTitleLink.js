import PropTypes from 'prop-types';
import React, { PureComponent } from 'react';
import Link from 'Components/Link/Link';
import TranslatedMovieTitleConnector from './TranslatedMovieTitleConnector';

class MovieTitleLink extends PureComponent {

  render() {
    const {
      titleSlug,
      id
    } = this.props;

    const link = `/movie/${titleSlug}`;

    return (
      <Link to={link}>
        <TranslatedMovieTitleConnector
          movieId={id}
        />
      </Link>
    );
  }
}

MovieTitleLink.propTypes = {
  titleSlug: PropTypes.string.isRequired,
  id: PropTypes.number.isRequired
};

export default MovieTitleLink;
