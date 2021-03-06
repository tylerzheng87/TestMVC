import React, { Component } from 'react'

export default class sortbutton extends Component {
    sortByName=()=>{
        let indexList = this.props.indexList;
        indexList.sort((a,b)=>{

          var nameA = a.username?.toUpperCase(); // ignore upper and lowercase
          var nameB = b.username?.toUpperCase(); // ignore upper and lowercase
            if (nameA < nameB) {
              return -1;
            }
            if (nameA > nameB) {
              return 1;
            }
            return 0;
        })
        this.setState({
            indexList
        })
      }
  
    render() {
        return (
            <div className="change_page">
                <span onClick={ this.sortByName } >Sort</span>
            </div>
        );
    }
}
