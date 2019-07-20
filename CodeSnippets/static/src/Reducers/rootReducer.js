const initState = {
    posts: [
        { id: '1',title: "Post 1 title"},
        { id: '2',title: "Post 2 title"},
        { id: '3',title: "Post 3 title"},
    ]
}

const rootReducer = (state = initState, action) => {
    console.log(action);
    if(action.type === 'DELETE_POST') {
        let newPosts = state.posts.filter(post => {
            return post.id!='1';
        });
        console.log('new posts:', newPosts);
        return {
            ...state, posts: newPosts
        }
    }
    return state;
}

export default rootReducer;