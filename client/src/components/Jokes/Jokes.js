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

  removeJoke=(jokeKey)=>{
    try {
      const copyJokesArray = this.state.jokesFromCategory.filter(x => x.id!==jokeKey);
      console.log('The new filtered copy is:', copyJokesArray);
      this.setState( prevState => ({
        ...prevState,
        jokesFromCategory:copyJokesArray
    }));
      console.log('The new jokesArray is: ', this.state.jokesFromCategory)
      deleteById(jokeKey);
    } catch (error) {
      console.log(`Coudn't remove joke with id ${jokeKey}: ${error}`);
    }

  }
  async componentDidMount() {
    console.log('jokes from category rendered');
    await getJokesByCategoryId(this.props.match.params.categoryId).then(x=>this.setState({jokesFromCategory: x}));
}

  render() {
    return (
      <Row className="justify-content-md-center">
{this.state.jokesFromCategory.map((joke, index) => {
  return <Joke key={joke.id} 
                id={joke.id} 
                content={joke.content} 
                authorId={joke.authorId} 
                createdOn={joke.createdOn} 
                pictureUrl={joke.pictureUrl}
                removeJoke={this.removeJoke.bind(this,joke.id)}/>
})}
  </Row>
    );
  }
}

export default Jokes;