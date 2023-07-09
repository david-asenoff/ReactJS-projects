import { Component, React, useState, useEffect } from 'react';
import { Link, Router } from "react-router-dom";
import { Container, Row } from 'react-bootstrap';
import styles from './JokeCategories.module.css';
import JokeCategory from '../JokeCategory/JokeCategory';
import { getAll } from '../../services/jokeCategoriesService';
import ReactPaginate from 'react-paginate';

class JokeCategories extends Component {
  constructor(props) {
    super(props);

    this.state = {
      offset: 0,
      data: [],
      perPage: 8,
      currentPage: 0,
    };

    this.handlePageClick = this
      .handlePageClick
      .bind(this);

  }

  async receivedData() {
        const data = await getAll();
        const slice = data.slice(this.state.offset, this.state.offset + this.state.perPage)
        const postData = slice.map(x =>
        (<JokeCategory
          key={x.id}
          id={x.id}
          name={x.name}
          pictureUrl={x.pictureUrl}
          jokesCount={x.jokesCount} />))

        this.setState({
          pageCount: Math.ceil(data.length / this.state.perPage),
          postData
        })
      };
  

  handlePageClick = (e) => {
    const selectedPage = e.selected;
    const offset = selectedPage * this.state.perPage;

    this.setState({
      currentPage: selectedPage,
      offset: offset
    }, () => {
      this.receivedData()
    });

  };

  componentDidMount(){
    this.receivedData();
  }

  render() {
    return (
      <>
        <div>
        <div className={styles.rowcenter}>
          {this.state.postData}
          </div>
          <ReactPaginate
            previousLabel={"предишна"}
            nextLabel={"следваща"}
            breakLabel={"..."}
            breakClassName={"break-me"}
            pageCount={this.state.pageCount}
            marginPagesDisplayed={2}
            pageRangeDisplayed={5}
            onPageChange={this.handlePageClick}
            containerClassName={"pagination"}
            subContainerClassName={"pages pagination"}
            activeClassName={"active"} />
        </div>
      </>
    );
  }
}

export default JokeCategories;