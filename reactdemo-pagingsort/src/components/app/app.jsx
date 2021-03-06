import React, { Component } from "react";
import PagingList from "../paging-list/paging-list";
import PagingButton from "../paging-pagebutton/page-button";
import data from "./data.json";
import PubSub from "pubsub-js";
export default class app extends Component {
  state = {
    indexList: [],
    numb: 0,
    data: data,
    current: 1,
    pageSize: 5,
    goValue: 0,
    totalPage: 0,
  };
  componentDidMount() {
    PubSub.subscribe("pageNext", (msg, num) => {
      this.setState({
        numb: num,
      });
      this.sortByName(this.state.numb);
    });
  }
  componentWillMount() {
    //setdata
    this.setState({
      totalPage: Math.ceil(this.state.data.length / this.state.pageSize),
    });
    this.pageNext(this.state.goValue);
  }
  sortByName = () => {
    const indexList = this.state.data;
    indexList.sort((a, b) => {
      var nameA = a.username?.toUpperCase(); // ignore upper and lowercase
      var nameB = b.username?.toUpperCase(); // ignore upper and lowercase
      if (nameA < nameB) {
        return -1;
      }
      if (nameA > nameB) {
        return 1;
      }
      return 0;
    });
    this.setState({
      indexList: this.state.data.slice(
        this.state.numb,
        this.state.numb + this.state.pageSize
      ),
    });
  };

  setPage = (num) => {
    this.setState({
      indexList: this.state.data.slice(num, num + this.state.pageSize),
    });
  };
  pageNext = (num) => {
    this.setPage(num);
  };

  render() {
    return (
      <div>
        <PagingList
          indexList={this.state.indexList}
          sortByName={this.sortByName}
        />
        <PagingButton {...this.state} />
      </div>
    );
  }
}
