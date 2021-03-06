import React, { Component } from "react";
import "./paging-list.css";
import PubSub from "pubsub-js";
export default class paginglist extends Component {
  render() {
    const { indexList } = this.props;

    return (
      <div className="table">
        <div className="table-header-group">
          <ul className="table-row">
            <li className="table-cell" onClick={this.props.sortByName}>
              UserName
            </li>
            <li className="table-cell">Email</li>
            <li className="table-cell">Street</li>
            <li className="table-cell">Suite</li>
            <li className="table-cell">City</li>
            <li className="table-cell">ZipCode</li>
            <li className="table-cell">Phone</li>
          </ul>
        </div>
        <div className="table-row-group">
          {indexList.map(function (data) {
            return (
              <ul className="table-row">
                <li className="table-cell">{data.username}</li>
                <li className="table-cell">{data.email}</li>
                <li className="table-cell">{data.suleet}</li>
                <li className="table-cell">{data.suite}</li>
                <li className="table-cell">{data.city}</li>
                <li className="table-cell">{data.zipcode}</li>
                <li className="table-cell">{data.phone}</li>
              </ul>
            );
          })}
        </div>
      </div>
    );
  }
}
