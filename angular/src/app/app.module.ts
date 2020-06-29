import { AccountConfigModule } from '@abp/ng.account.config';
import { CoreModule } from '@abp/ng.core';
import { IdentityConfigModule } from '@abp/ng.identity.config';
import { SettingManagementConfigModule } from '@abp/ng.setting-management.config';
import { TenantManagementConfigModule } from '@abp/ng.tenant-management.config';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgxsLoggerPluginModule } from '@ngxs/logger-plugin';
import { NgxsModule } from '@ngxs/store';
import { environment } from '../environments/environment';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SharedModule } from './shared/shared.module';
import { TodoRoutingModule } from './todo/todo-routing.module';
import { StoreModule } from '@ngrx/store';
import { EffectsModule, Effect } from '@ngrx/effects';
import * as fromApp from './store/app.reducer';
import { TodoEffects } from './todo/store/todo.effects';
import { TodoModule } from './todo/todo.module';

const LOGGERS = [NgxsLoggerPluginModule.forRoot({ disabled: false })];

@NgModule({
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    TodoRoutingModule,
    TodoModule,
    CoreModule.forRoot({
      environment,
    }),
    ThemeSharedModule.forRoot(),
    AccountConfigModule.forRoot({ redirectUrl: '/' }),
    IdentityConfigModule,
    TenantManagementConfigModule,
    SettingManagementConfigModule,
    NgxsModule.forRoot(),
    SharedModule,
    ...(environment.production ? [] : LOGGERS),
    StoreModule.forRoot(fromApp.appReducers),
    EffectsModule.forRoot([TodoEffects])
  ],
  declarations: [AppComponent],
  bootstrap: [AppComponent],
})
export class AppModule {}
