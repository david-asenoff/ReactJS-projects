import { Component, React } from 'react';
import { Card, Col, Button, Alert, Form } from 'react-bootstrap';
import Moment from 'moment';
import { getAll } from '../../services/jokeCategoriesService';
import { getById, deleteById, updateById } from '../../services/jokesService';
import History from './../History/History'

class JokeDetails extends Component {

  constructor(props) {
    super(props)

    this.state = {
      joke: {},
      jokeCategories: [],
      showDeleteButton: true,
      showDeleteAlert: false,
      showEditButton: true,
      deleteButtonText: 'Изтрий',
      showEditForm: false,
      editButtonText: 'Редактирай',
      showUpdateAlert: false,
      newJoke: '',
      newCategories: [],
    };
  }
  componentDidUpdate() {
    console.log('updated');
  }
  async componentDidMount() {
    console.log('joke details rendered');
    await getById(this.props.match.params.jokeId).then(x => this.setState({ joke: x }));
    await getAll().then(x => this.setState({ jokeCategories: x }));
    this.setState({ newJoke: this.state.joke });
  }
  render() {
    const deleteAlertHideSwitch = () => this.setState({ showDeleteAlert: !this.state.showDeleteAlert });
    const deleteButtonTextSwitch = () => this.setState({ showDeleteAlert: !this.state.showDeleteAlert, deleteButtonText: this.state.deleteButtonText == "Изтрий" ? "Откажи" : "Изтрий" });
    const editFormHideSwitch = () => this.setState({ showEditForm: !this.state.showEditForm });
    const editButtonTextSwitch = () => this.setState({ showUpdateAlert: !this.state.showUpdateAlert, showEditForm: !this.state.showEditForm, editButtonText: this.state.editButtonText === "Редактирай" ? "Откажи" : "Редактирай" });
    const deleteThisJoke = (event) => {
      event.preventDefault();
      History.push("/")
      deleteById(this.state.joke.id)
    };
    const updateThisJoke = (event) => {
      event.preventDefault();
      History.push("/")
      const editedText = document.getElementById('editedText').value;
      const id = this.state.joke.id;
      updateById({ id, editedText })
    };
    return (
      <Col sm={12}>
        <Card key={this.state.joke.id}>
          <Card.Header as="small">от {this.props.authorId ?? 'Anonymous'}, {Moment(this.props.createdOn).format('MM-DD-YYYY')}</Card.Header>
          {!this.state.showEditForm ?
            <Card.Body>
              <Card.Text>
                {this.state.joke.content}
              </Card.Text>
            </Card.Body>
            :
            <Form show={this.state.showEditForm}>
              <Form.Group controlId="editJoke">
                <Form.Label>Съдържание</Form.Label>
                <Form.Control id="editedText" as="textarea" placeholder="Съдържание" defaultValue={this.state.joke.content} />
              </Form.Group>
            </Form>
          }
          <Card.Footer as="small">
            {this.state.showDeleteButton ? <Button onClick={deleteAlertHideSwitch, deleteButtonTextSwitch} variant="danger">
              {this.state.deleteButtonText}
            </Button> : ""}
            {this.state.showEditButton ? <Button onClick={editFormHideSwitch, editButtonTextSwitch} variant="warning">
              {this.state.editButtonText}
            </Button> : ""}
            {/* DELETE */}
            <Alert show={this.state.showDeleteAlert} variant="success" style={{ maxWidth: 500 }}>
              <Alert.Heading>Искате ли да изтриете този виц?</Alert.Heading>
              <p>
                Наистина ли искате да изтриете този виц? - {this.state.joke.content}
              </p>
              <hr />
              <div className="d-flex justify-content-end">
                <Button variant="outline-danger" onClick={deleteThisJoke}>
                  Да, изтрий
            </Button>
                <Button onClick={deleteAlertHideSwitch, deleteButtonTextSwitch} variant="outline-success">
                  Не, не изтривай
          </Button>
              </div>
            </Alert>
            {/* UPDATE */}
            <Alert show={this.state.showUpdateAlert} variant="success" style={{ maxWidth: 500 }}>
              <Alert.Heading>Искате ли да редактирате този виц?</Alert.Heading>
              <hr />
              <div className="d-flex justify-content-end">
                <Button variant="outline-danger" onClick={updateThisJoke}>
                  Да, редактирай
                </Button>
                <Button onClick={deleteAlertHideSwitch, deleteButtonTextSwitch} variant="outline-success">
                  Не, не редактирай
          </Button>
              </div>
            </Alert>
          </Card.Footer>
        </Card>
      </Col>
    );
  }
}
export default JokeDetails;