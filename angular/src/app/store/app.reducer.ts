import * as fromTodo from '../todo/store/todo.reducer';
import { ActionReducerMap } from '@ngrx/store';

export interface AppState {
  todo: fromTodo.TodoState;
}

export const appReducers: ActionReducerMap<AppState> = {
  todo: fromTodo.todoReducer
};