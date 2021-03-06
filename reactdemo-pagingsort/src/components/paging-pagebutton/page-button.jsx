import React, { Component } from "react";
import PubSub from "pubsub-js";
export default class pagebutton extends Component {
  state = {
    num: 0,
    pagenum: this.props.current,
  };

  //下一页
  setNext = () => {
    if (this.state.pagenum < this.props.totalPage) {
      this.setState(
        {
          num: this.state.num + this.props.pageSize,
          pagenum: this.state.pagenum + 1,
        },
        function () {
          PubSub.publish("pageNext", this.state.num);
        }
      );
    }
  };

  //上一页
  setUp = () => {
    if (this.state.pagenum > 1) {
      this.setState(
        {
          num: this.state.num - this.props.pageSize,
          pagenum: this.state.pagenum - 1,
        },
        function () {
          PubSub.publish("pageNext", this.state.num);
        }
      );
    }
  };

  render() {
    return (
      <div className="change_page">
        <span onClick={this.setUp}>上一页</span>
        <span>
          {this.state.pagenum}页/ {this.props.totalPage}页
        </span>
        <span onClick={this.setNext}>下一页</span>
      </div>
    );
  }
}
