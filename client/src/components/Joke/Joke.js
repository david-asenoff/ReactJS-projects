import { Component, React } from 'react';
import { Link, Router } from "react-router-dom";
import { Container, Row, Toast, Card, CardGroup, Col, ButtonGroup, Button, Alert} from 'react-bootstrap';
import styles from './Joke.module.css';
import Moment from 'moment';

class Joke extends Component {
  constructor(props) {
    super(props)

    this.state = { show: false, deleteButtonText:'Изтрий' };
  }
  componentDidUpdate() {
    console.log('updated');
  }
  render() {
    const deleteAlertHideSwitch = () => this.setState({ show: !this.state.show });
    const deleteButtonTextSwitch = () => this.setState({ show: !this.state.show, deleteButtonText: this.state.deleteButtonText=="Изтрий"?"Откажи":"Изтрий" });;
    return (
      <Col sm={12}>
   <Card key={this.props.id} className="mt-5">
   <Card.Header as="small" className="p-1">
     от {this.props.authorId??'Anonymous'}, 
     {Moment(this.props.createdOn).format('MM-DD-YYYY')}
     {this.props.content!=null?
     <Link to={`/joke/${this.props.id}`}>
     <Button variant="outline-primary" size="sm" className="ml-2">Редакция</Button>
     </Link>:
     ''}
     </Card.Header>
    <Card.Body>
      <Card.Text>
      {this.props.content}
      </Card.Text>
    </Card.Body>
  </Card>
</Col>
    );
  }
}
export default Joke;