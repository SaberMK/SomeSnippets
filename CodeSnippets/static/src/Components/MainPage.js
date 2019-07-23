import React, { Component } from 'react';
import { connect } from "react-redux";
import { deletePost } from '../Actions/postActions.js';

//import axios from 'axios';

class MainPage extends Component {

    render() {
        console.log(this.props);
        const { posts } = this.props;

        let items = posts.map((item) => 
            <p key={item.id}>{item.title}</p>
        );

        return ( <div>
            <h1 position="center">Main Component</h1>
            {items}
            
            <button onClick={()=>{this.props.deletePost(0)}}>
                DeletePost
            </button>
        </div> );
    }
}

const mapStateToProps = (state) => {
    return {
        posts: state.posts
    }
}

const mapDispatchtoProps = (dispatch) => {
    return {
        deletePost: (id) => { dispatch(deletePost(id)) }
    }
}

export default connect(mapStateToProps, mapDispatchtoProps)(MainPage);