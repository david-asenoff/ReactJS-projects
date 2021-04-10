import { Component, React } from 'react';
import { Card, Col, Button, Alert, Form } from 'react-bootstrap';
import Moment from 'moment';
import { getAll } from '../../services/jokeCategoriesService';
import { getById } from '../../services/jokesService';

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
    };
  }
  componentDidUpdate() {
    console.log('updated');
  }
  componentDidMount() {
    console.log('joke details rendered');
    getById(this.props.match.params.jokeId).then(x => this.setState({ joke: x }));
    getAll().then(x => this.setState({ jokeCategories: x }));
  }
  render() {
    const deleteAlertHideSwitch = () => this.setState({ showDeleteAlert: !this.state.showDeleteAlert });
    const deleteButtonTextSwitch = () => this.setState({ showDeleteAlert: !this.state.showDeleteAlert, deleteButtonText: this.state.deleteButtonText == "Изтрий" ? "Откажи" : "Изтрий" });
    const editFormHideSwitch = () => this.setState({ showEditForm: !this.state.showEditForm });
    const editButtonTextSwitch = () => this.setState({ showEditForm: !this.state.showEditForm, editButtonText: this.state.editButtonText === "Редактирай" ? "Откажи" : "Редактирай" });
    return (
      <Col sm={12}>
        <Card key={this.state.joke.id}>
          <Card.Header as="small">от {this.props.authorId ?? 'Anonymous'}, {Moment(this.props.createdOn).format('MM-DD-YYYY')}</Card.Header>
          {!this.state.showEditForm?
          <Card.Body>
          <Card.Text>
            {this.state.joke.content}
          </Card.Text>
        </Card.Body>
          :
          <Form show={this.state.showEditForm}>
              <Form.Group controlId="formBasicEmail">
                <Form.Label>Съдържание</Form.Label>
                <Form.Control as="textarea" placeholder="Съдържание" defaultValue={this.state.joke.content} />
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
                    checked={this.state.joke.categories.map(x => x.id).includes(x.id) ? 'checked' : undefined}
                  />
                })}
              </Form.Group>
            </Form>
          }
          
          <Card.Footer as="small">
            {this.state.showDeleteButton?<Button onClick={deleteAlertHideSwitch, deleteButtonTextSwitch} variant="danger">
              {this.state.deleteButtonText}
            </Button>:""}
            {this.state.showEditButton?<Button onClick={editFormHideSwitch, editButtonTextSwitch} variant="warning">
              {this.state.editButtonText}
            </Button>:""}
            {/* DELETE */}
            <Alert show={this.state.showDeleteAlert} variant="success" style={{ maxWidth: 500 }}>
              <Alert.Heading>Искате ли да изтриете този виц?</Alert.Heading>
              <p>
                Наистина ли искате да изтриете този виц? - {this.state.joke.content}
              </p>
              <hr />
              <div className="d-flex justify-content-end">
                <Button variant="outline-danger" onClick={this.state.joke.removeJoke}>
                  Да, изтрий
            </Button>
                <Button onClick={deleteAlertHideSwitch, deleteButtonTextSwitch} variant="outline-success">
                  Не, не изтривай
          </Button>
              </div>
            </Alert>
            {/* UPDATE */}

            
          </Card.Footer>
        </Card>
      </Col>
    );
  }
}
export default JokeDetails;