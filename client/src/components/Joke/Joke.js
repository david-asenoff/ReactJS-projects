import { Component, React } from 'react';
import { Link, Router } from "react-router-dom";
import { Container, Row, Toast, Card, CardGroup, Col, ButtonGroup, Button, Alert} from 'react-bootstrap';
import styles from './Joke.module.css';
import Moment from 'moment';

class Joke extends Component {
  constructor(props) {
    super(props)

    this.state = { show: false };
  }
  componentDidUpdate() {
    console.log('updated');
  }
  render() {
    const handleHide = () => this.setState({ show: false });
		const handleShow = () => this.setState({ show: true });
    return (
      <Col sm={12}>
   <Card key={this.props.id}>
   <Card.Header as="small">от {this.props.authorId??'Anonymous'}, {Moment(this.props.createdOn).format('MM-DD-YYYY')}</Card.Header>
    <Card.Body>
      <Card.Text>
      {this.props.content}
      </Card.Text>
    </Card.Body>
    <Card.Footer as="small">
    <Alert show={this.state.show} variant="success" style={{ maxWidth: 500 }}>
					<Alert.Heading>Искате ли да изтриете този виц?</Alert.Heading>
					<p>
						Наистина ли искате да изтриете този виц? - {this.props.content}
          </p>
					<hr />
					<div className="d-flex justify-content-end">
          <Button variant="outline-danger" onClick={this.props.removeJoke}>
							Да
            </Button>
						<Button onClick={handleHide} variant="outline-success">
							Не
          </Button>
					</div>
				</Alert>
				{!this.state.show && <Button onClick={handleShow} variant="danger">Изтрий</Button>}
    </Card.Footer>
  </Card>
</Col>
    );
  }
}
export default Joke;