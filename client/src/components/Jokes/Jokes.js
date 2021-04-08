import { Component } from 'react';
// import { Link, Router } from "react-router-dom";
import { Container, Row, CardGroup } from 'react-bootstrap';
import Joke from '../Joke/Joke';
import {getJokesByCategoryId} from '../../services/jokeCategoriesService';
import  {deleteById}  from '../../services/jokesService';

class Jokes extends Component {
  constructor(props) {
    super(props)
    this.state = {
      jokesFromCategory: [],
    }
    console.log('JOKES rendered');
  }

  removeJoke(jokeId) {
    try {
      deleteById(jokeId);

      this.setState(state => ({
        jokesFromCategory: this.state.jokesFromCategory.filter(function(value, index, arr){ 
          return value.id!==jokeId;
      })}));
    } catch (error) {
      console.log(`Coudn't remove joke with id ${jokeId}: ${error}`);
    }

  }
  componentDidMount() {
    console.log('jokes from category rendered');
    getJokesByCategoryId(this.props.match.params.categoryId).then(x=>this.setState({jokesFromCategory: x}));
}

  render() {
    return (
      <Row className="justify-content-md-center">
{this.state.jokesFromCategory.map(x => {
  return <Joke key={x.id} 
                id={x.id} 
                content={x.content} 
                authorId={x.authorId} 
                createdOn={x.createdOn} 
                pictureUrl={x.pictureUrl}
                removeJoke={this.removeJoke}/>
})}
  </Row>
    );
  }
}

export default Jokes;