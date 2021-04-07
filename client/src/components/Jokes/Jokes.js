import { Component } from 'react';
// import { Link, Router } from "react-router-dom";
// import { Container, Row } from 'react-bootstrap';
import Joke from '../Joke/Joke';
import {getJokesByCategoryId} from '../../services/jokeCategoriesService'

class Jokes extends Component {
  constructor(props) {
    super(props)
    this.state = {
      jokesFromCategory: [],
    }
    console.log('JOKES rendered');
  }

  componentDidMount() {
    console.log('jokes from category rendered');
    getJokesByCategoryId(this.props.match.params.categoryId).then(x=>this.setState({jokesFromCategory: x}));
}

  render() {
    return (
      <div>
{this.state.jokesFromCategory.map(x => {
  return <Joke key={x.id} id={x.id} content={x.content} authorId={x.authorId}/>
})}
</div>
    );
  }
}

export default Jokes;