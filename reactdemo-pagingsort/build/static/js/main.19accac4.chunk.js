(this.webpackJsonptest=this.webpackJsonptest||[]).push([[0],{13:function(e,t,a){},19:function(e,t,a){"use strict";a.r(t);var n=a(1),s=a(11),i=a(2),l=a(3),c=a(6),r=a(5),o=(a(13),a(4)),u=a.n(o),m=a(0),h=function(e){Object(c.a)(a,e);var t=Object(r.a)(a);function a(){return Object(i.a)(this,a),t.apply(this,arguments)}return Object(l.a)(a,[{key:"render",value:function(){var e=this.props.indexList;return Object(m.jsxs)("div",{className:"table",children:[Object(m.jsx)("div",{className:"table-header-group",children:Object(m.jsxs)("ul",{className:"table-row",children:[Object(m.jsx)("li",{className:"table-cell",onClick:this.props.sortByName,children:"UserName"}),Object(m.jsx)("li",{className:"table-cell",children:"Email"}),Object(m.jsx)("li",{className:"table-cell",children:"Street"}),Object(m.jsx)("li",{className:"table-cell",children:"Suite"}),Object(m.jsx)("li",{className:"table-cell",children:"City"}),Object(m.jsx)("li",{className:"table-cell",children:"ZipCode"}),Object(m.jsx)("li",{className:"table-cell",children:"Phone"})]})}),Object(m.jsx)("div",{className:"table-row-group",children:e.map((function(e){return Object(m.jsxs)("ul",{className:"table-row",children:[Object(m.jsx)("li",{className:"table-cell",children:e.username}),Object(m.jsx)("li",{className:"table-cell",children:e.email}),Object(m.jsx)("li",{className:"table-cell",children:e.suleet}),Object(m.jsx)("li",{className:"table-cell",children:e.suite}),Object(m.jsx)("li",{className:"table-cell",children:e.city}),Object(m.jsx)("li",{className:"table-cell",children:e.zipcode}),Object(m.jsx)("li",{className:"table-cell",children:e.phone})]})}))})]})}}]),a}(n.Component),p=function(e){Object(c.a)(a,e);var t=Object(r.a)(a);function a(){var e;Object(i.a)(this,a);for(var n=arguments.length,s=new Array(n),l=0;l<n;l++)s[l]=arguments[l];return(e=t.call.apply(t,[this].concat(s))).state={num:0,pagenum:e.props.current},e.setNext=function(){e.state.pagenum<e.props.totalPage&&e.setState({num:e.state.num+e.props.pageSize,pagenum:e.state.pagenum+1},(function(){u.a.publish("pageNext",this.state.num)}))},e.setUp=function(){e.state.pagenum>1&&e.setState({num:e.state.num-e.props.pageSize,pagenum:e.state.pagenum-1},(function(){u.a.publish("pageNext",this.state.num)}))},e}return Object(l.a)(a,[{key:"render",value:function(){return Object(m.jsxs)("div",{className:"change_page",children:[Object(m.jsx)("span",{onClick:this.setUp,children:"\u4e0a\u4e00\u9875"}),Object(m.jsxs)("span",{children:[this.state.pagenum,"\u9875/ ",this.props.totalPage,"\u9875"]}),Object(m.jsx)("span",{onClick:this.setNext,children:"\u4e0b\u4e00\u9875"})]})}}]),a}(n.Component),b=a(9),d=function(e){Object(c.a)(a,e);var t=Object(r.a)(a);function a(){var e;Object(i.a)(this,a);for(var n=arguments.length,s=new Array(n),l=0;l<n;l++)s[l]=arguments[l];return(e=t.call.apply(t,[this].concat(s))).state={indexList:[],numb:0,data:b,current:1,pageSize:5,goValue:0,totalPage:0},e.sortByName=function(){e.state.data.sort((function(e,t){var a,n,s=null===(a=e.username)||void 0===a?void 0:a.toUpperCase(),i=null===(n=t.username)||void 0===n?void 0:n.toUpperCase();return s<i?-1:s>i?1:0})),e.setState({indexList:e.state.data.slice(e.state.numb,e.state.numb+e.state.pageSize)})},e.setPage=function(t){e.setState({indexList:e.state.data.slice(t,t+e.state.pageSize)})},e.pageNext=function(t){e.setPage(t)},e}return Object(l.a)(a,[{key:"componentDidMount",value:function(){var e=this;u.a.subscribe("pageNext",(function(t,a){e.setState({numb:a}),e.sortByName(e.state.numb)}))}},{key:"componentWillMount",value:function(){this.setState({totalPage:Math.ceil(this.state.data.length/this.state.pageSize)}),this.pageNext(this.state.goValue)}},{key:"render",value:function(){return Object(m.jsxs)("div",{children:[Object(m.jsx)(h,{indexList:this.state.indexList,sortByName:this.sortByName}),Object(m.jsx)(p,Object(s.a)({},this.state))]})}}]),a}(n.Component),j=a(10);a.n(j).a.render(Object(m.jsx)(d,{}),document.getElementById("root"))},9:function(e){e.exports=JSON.parse('[{"gender":"Male","name":"Leanne Graham","username":"Bret","street":"Kulas Light","suite":"Apt. 556","city":"Gwenborough","zipcode":"92998-3874","phone":"1-770-736-8031 x56442","website":"hildegard.org"},{"gender":"Male","name":"Ervin Howell","username":"Antonette","email":"Shanna@melissa.tv","street":"Victor Plains","suite":"Suite 879","city":"Wisokyburgh","zipcode":"90566-7771"},{"gender":"Female","name":"Clementine Bauch","username":"Samantha","email":"Nathan@yesenia.net","phone":"1-463-123-4447","website":"ramiro.info"},{"gender":"Male","name":"Patricia Lebsack","username":"Karianne","email":"Julianne.OConner@kory.org","street":"Hoeger Mall","suite":"Apt. 692","city":"South Elvis","zipcode":"53919-4257"},{"gender":"Female","name":"Chelsey Dietrich","username":"garianne","email":"Lucio_Hettinger@annie.ca","street":"Skiles Walks","suite":"Suite 351","city":"Roscoeview","zipcode":"33263","phone":"(254)954-1289","website":"demarco.info"},{"gender":"Female","name":"Dennis Schulist","username":"Oaxime_Nienow","email":"Karley_Dach@jasper.info","street":"Norberto Crossing","suite":"Apt. 950","city":"South Christy","zipcode":"23505-1337","phone":"1-477-935-8478 x6430","website":"ola.org"},{"gender":"Male","name":"Kurtis Weissnat","username":"Qaxime_Nienow","street":"Rex Trail","suite":"Suite 280","city":"Howemouth","zipcode":"58804-1099","phone":"210.067.6132","website":"elvis.io"},{"gender":"Male","name":"Nicholas Runolfsdottir V","username":"Maxime_Nienow","email":"Sherwood@rosamond.me","phone":"586.493.6943 x140","website":"jacynthe.com"},{"gender":"Female","name":"Glenna Reichert","username":"Delphine","email":"Chaim_McDermott@dana.io","street":"Dayna Park","suite":"Suite 449","city":"Bartholomebury","website":"conrad.com"},{"name":"Clementina DuBuque","username":"Moriah.Stanton","email":"Rey.Padberg@karina.biz","street":"Kattie Turnpike","suite":"Suite 198","city":"Lebsackbury","zipcode":"31428-2261","phone":"024-648-3804"}]')}},[[19,1,2]]]);
//# sourceMappingURL=main.19accac4.chunk.js.map