import { Component, React } from 'react';
import { Link, Router } from "react-router-dom";
import { Container, Row, Toast, Card, CardGroup, Col, ButtonGroup, Button, Alert, Form} from 'react-bootstrap';
import styles from './JokeDetails.module.css';
import Moment from 'moment';
import {getJokesByCategoryId, getAll} from '../../services/jokeCategoriesService';
import  {deleteById, getById}  from '../../services/jokesService';

class JokeDetails extends Component {
  constructor(props) {
    super(props)

    this.state = { joke:{}, 
    jokeCategories: [] ,
    showDeleteAlert: false, 
    deleteButtonText:'Изтрий', 
    showUpdateAlert: false,
    updateButtonText: 'Редактирай', };
  }
  componentDidUpdate() {
    console.log('updated');
  }
  componentDidMount() {
    console.log('joke details rendered');
    getById(this.props.match.params.jokeId).then(x=>this.setState({joke: x}));
    getAll().then(x=>this.setState({jokeCategories: x}));
}
  render() {
    const deleteAlertHideSwitch = () => this.setState({ showDeleteAlert: !this.state.showDeleteAlert });
    const deleteButtonTextSwitch = () => this.setState({ showDeleteAlert: !this.state.showDeleteAlert, deleteButtonText: this.state.deleteButtonText=="Изтрий"?"Откажи":"Изтрий" });
    const updateAlertHideSwitch = () => this.setState({ showUpdateAlert: !this.state.showUpdateAlert });
    const updateButtonTextSwitch = () => this.setState({ showUpdateAlert: !this.state.showUpdateAlert, updateButtonText: this.state.updateButtonText=="Редактирай"?"Откажи":"Редактирай" });
    return (
      <Col sm={12}>
   <Card key={this.state.joke.id}>
   <Card.Header as="small">от {this.props.authorId??'Anonymous'}, {Moment(this.props.createdOn).format('MM-DD-YYYY')}</Card.Header>
    <Card.Body>
      <Card.Text>
      {this.state.joke.content}
      </Card.Text>
    </Card.Body>
    <Card.Footer as="small">
    <Button onClick={deleteAlertHideSwitch, deleteButtonTextSwitch} variant="danger">
          {this.state.deleteButtonText}
        </Button>
        <Button onClick={updateAlertHideSwitch, updateButtonTextSwitch} variant="warning">
          {this.state.updateButtonText}
        </Button>
      {/* DELETE */}
    <Alert show={this.state.showDeleteAlert} variant="success" style={{ maxWidth: 500 }}>
					<Alert.Heading>Искате ли да изтриете този виц?</Alert.Heading>
					<p>
						Наистина ли искате да изтриете този виц? - {this.state.joke.content}
          </p>
					<hr />
					<div className="d-flex justify-content-end">
          <Button variant="outline-danger" onClick={this.state.joke.removeJoke}>
							Да
            </Button>
						<Button onClick={deleteAlertHideSwitch, deleteButtonTextSwitch} variant="outline-success">
							Не
          </Button>
					</div>
				</Alert>
      {/* UPDATE */}
      <Alert show={this.state.showUpdateAlert} variant="success" style={{ maxWidth: 500 }}>
<Alert.Heading>
      <Form>
      <Form.Group controlId="formBasicEmail">
    <Form.Label>Съдържание</Form.Label>
    <Form.Control as="textarea" placeholder="Съдържание" defaultValue={this.state.joke.content}/>
  </Form.Group>
  <Form.Group controlId="exampleForm.ControlSelect2">
  <Form.Label>Категории: </Form.Label>
  <br></br>
      {this.state.jokeCategories.map(x => {
            return <Form.Check
            custom
            inline
            label={x.name}
            type='checkbox'
            id={x.id}
            key={x.id}
            checked = {this.state.joke.categories.map(x=>x.id).includes(x.id)?'checked':''}
            />
          })}
  </Form.Group>
      </Form>
      </Alert.Heading>
      </Alert>
    </Card.Footer>
  </Card>
</Col>
    );
  }
}
export default JokeDetails;