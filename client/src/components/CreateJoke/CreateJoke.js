import { Component } from 'react';
import styles from './CreateJoke.module.css';
import { Card, Col, Button, Alert, Form } from 'react-bootstrap';
import { getAll } from '../../services/jokeCategoriesService';
import {createJoke} from './../../services/jokesService';
import History from './../History/History'

class CreateJoke extends Component {
  state = { content:'', name:'', pictureUrl:'' };
    
  handleSubmit = async (event) => {
    const name= this.state.name;
    const pictureUrl= this.state.pictureUrl;
    const content= this.state.content;
    createJoke(name, pictureUrl, content)
  };

  render() {
    return (
      <form onSubmit={this.handleSubmit}>
        <h1>Създаване на нов виц</h1>
          <input 
            type="text"
            onChange={event => this.setState({ content: event.target.value })}
            placeholder="Enter Joke Name" 
            required 
          />
          <input 
            type="text"
            onChange={event => this.setState({ name: event.target.value })}
            placeholder="Enter Category Name" 
            required 
          />
          <input 
            type="text"
            onChange={event => this.setState({ pictureUrl: event.target.value })}
            placeholder="Enter Category Picture Url" 
            required 
          />
          <button>Go!</button>
        </form>
      );
    }
}

export default CreateJoke;