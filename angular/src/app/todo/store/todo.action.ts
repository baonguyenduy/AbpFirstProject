import { Action } from '@ngrx/store';
import { Todo } from '../todo.model';

export const GET_TODOS = '[Todo] Get Todos';
export const CREATE_TODO = '[Todo] Create Todo';
export const SET_TODOS = '[Todo] Set Todos';
export const DELETE_TODO = '[Todo] Delete Todo';
export const UPDATE_TODO = '[Todo] Update Todo';

export class GetTodos implements Action {
  readonly type = GET_TODOS;
}

export class SetTodos implements Action {
  readonly type = SET_TODOS;

  constructor(public payload: { todos: Todo[] }) {

  }
}

export class CreateTodo implements Action {
  readonly type = CREATE_TODO;

  constructor(public payload: { note: string }) {

  }
}

export class UpdateTodo implements Action {
  readonly type = UPDATE_TODO;

  constructor(public payload: { id: string, note: string }) {
    
  }
}

export class DeleteTodo implements Action {
  readonly type = DELETE_TODO;

  constructor(public payload: { id: string }) {

  }
}

export type TodoAction = GetTodos |
  SetTodos | 
  CreateTodo | 
  UpdateTodo |
  DeleteTodo;