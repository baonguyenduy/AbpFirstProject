import { State } from '@ngrx/store';

import { Todo } from '../todo.model';
import * as TodoActions from './todo.action';

export interface TodoState {
  todos: Todo[];
}

const initialState: TodoState = {
  todos: []
};

export const todoReducer = (state = initialState, action: TodoActions.TodoAction) => {
  switch (action.type) {
    case TodoActions.SET_TODOS:
      return {
        ...state,
        todos: action.payload.todos
      }
    default:
      return state;
  }
}