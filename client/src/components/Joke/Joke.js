import { Component, React } from 'react';
import { Link, Router } from "react-router-dom";
import { Container, Row } from 'react-bootstrap';
import styles from './Joke.module.css';

class Joke extends Component {
  constructor(props) {
    super(props)

    this.state = {
    }
  }

  render() {
    return (
        <div>
        <h4>{this.props.createdOn} от {this.props.authorId}</h4>
        <p>{this.props.content}</p>
    </div>
    );
  }
}
export default Joke;