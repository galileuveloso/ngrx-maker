using NgRxMaker.Models;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace NgRxMaker
{
    public static class Maker
    {
        private static readonly IList<Directory> directories = new List<Directory>()
        {
            new Directory
            {
                Files = new List<File>()
                {
                    new File { Name = "index.ts", Content = "export * from './actions';\r\nexport * from './effects';\r\nexport * from './reducers';\r\nexport * from './selectors';" }
                }
            },
            new Directory
            {
                Path = "helpers",
                Files = new List<File>()
                {
                    new File { Name = "@feature-helper.ts", Content = "export class @entityHelper {\r\n\r\n}" },
                    new File { Name = "index.ts", Content = "export * from './@feature-helper';"}
                }
            },
            new Directory
            {
                Path = "modules",
                Files = new List<File>()
                {
                    new File { Name = "@feature.module.ts", Content = "import { NgModule } from '@angular/core';\r\nimport { CommonModule } from '@angular/common';\r\nimport { StoreModule } from '@ngrx/store';\r\nimport * as fromE@entity from '../store/reducers';\r\nimport { EffectsModule } from '@ngrx/effects';\r\nimport { @entityEffects } from '../store/effects';\r\n\r\n@NgModule({\r\n  declarations: [],\r\n  imports: [\r\n    CommonModule,\r\n    StoreModule.forFeature(from@entity.@fEATUREFeatureKey, from@entity.@fEATUREReducer),\r\n    EffectsModule.forFeature([@entityEffects])\r\n  ]\r\n})\r\nexport class @entityModule { }\r\n" },
                    new File { Name = "index.ts", Content = "export * from './@feature.module';" }
                }
            },
            new Directory
            {
                Path = "resolvers",
                Files = new List<File>()
                {
                    new File { Name = "@feature.resolver.ts", Content =  "import { Resolve, RouterStateSnapshot, ActivatedRouteSnapshot } from '@angular/router';\r\nimport { Injectable } from '@angular/core';\r\nimport { Observable, of } from 'rxjs';\r\nimport { Store } from '@ngrx/store';\r\nimport { AppState } from 'src/app/store';\r\nimport { selecionar@entity } from '../store';\r\n\r\n@Injectable({\r\n  providedIn: 'root'\r\n})\r\nexport class @entityResolver implements Resolve<boolean> {\r\n  constructor(\r\n    private store: Store<AppState>\r\n  ) { }\r\n\r\n  resolve(\r\n    route: ActivatedRouteSnapshot,\r\n    state: RouterStateSnapshot\r\n  ): Observable<boolean> {\r\n    this.store.dispatch(selecionar@entity());\r\n    return of(true);\r\n  }\r\n}\r\n" },
                    new File { Name = "index.ts", Content = "export * from './@feature.resolver';" }
                }
            },
            new Directory
            {
                Path = "store",
                Files = new List<File>()
                {
                    new File { Name = "index.ts", Content = "export * from './actions';\r\nexport * from './effects';\r\nexport * from './reducers';\r\nexport * from './selectors';" }
                },
                Directories = new List<Directory>()
                {
                    new Directory
                    {
                        Path = "actions",
                        Files = new List<File>()
                        {
                            new File { Name = "@feature.actions.ts", Content = "import {\r\n  createAction,\r\n  props\r\n} from '@ngrx/store';\r\n\r\nimport {\r\n  HttpResponseError\r\n} from 'src/app/core';\r\n\r\nimport {\r\n  @entity\r\n} from 'src/app/domain';\r\n\r\nexport const selecionar@entity = createAction(\r\n  '[@entity] Selecionar @entity'\r\n);\r\n\r\nexport const selecionar@entitySuccess = createAction(\r\n  '[@entity] Selecionar @entity Success',\r\n  props<{\r\n    response: @entity[]\r\n  }>()\r\n);\r\n\r\nexport const selecionar@entityFailure = createAction(\r\n  '[@entity] Selecionar @entity Failure',\r\n  props<{\r\n    error: HttpResponseError\r\n  }>()\r\n);" },
                            new File { Name = "index.ts", Content = "export * from './@feature.actions';" }
                        }
                    },
                    new Directory
                    {
                        Path = "effects",
                        Files = new List<File>()
                        {
                            new File { Name = "@feature.effects.ts", Content = "import { Injectable } from '@angular/core';\r\nimport { Actions, createEffect, ofType } from '@ngrx/effects';\r\nimport { catchError, map, concatMap } from 'rxjs/operators';\r\nimport { of } from 'rxjs';\r\nimport { AppState } from 'src/app/store';\r\nimport { Store } from '@ngrx/store';\r\n\r\nimport {\r\n  DocumentoService,\r\n  inserirSnackBar,\r\n  SnackBarHelper\r\n} from 'src/app/core';\r\n\r\nimport {\r\n  @entity\r\n} from 'src/app/domain';\r\n\r\nimport {\r\n  @fEATURERoute\r\n} from 'src/app/features';\r\n\r\nimport * as actions from '../actions';\r\n\r\n@Injectable()\r\nexport class @entityEffects {\r\n\r\n  constructor(\r\n    private actions$: Actions,\r\n    private service: DocumentoService<@entity>,\r\n    private store: Store<AppState>\r\n  ) { }\r\n\r\n  selecionar@entity$ = createEffect(() => {\r\n    return this.actions$.pipe(\r\n      ofType(actions.selecionar@entity),\r\n      concatMap((action) =>\r\n        this\r\n          .service\r\n          .get<@entity[]>(@fEATURERoute)\r\n          .pipe(\r\n            map(response => actions.selecionar@entitySuccess({ response })),\r\n            catchError(error => {\r\n              this.store.dispatch(inserirSnackBar({ mensagem: SnackBarHelper.HttpFalha(error) }));\r\n              return of(actions.selecionar@entityFailure({ error }))\r\n            }))\r\n      ));\r\n  });\r\n}\r\n" },
                            new File { Name = "index.ts",  Content = "export * from './@feature.effects';" }
                        }
                    },
                    new Directory
                    {
                        Path = "reducers",
                        Files = new List<File>()
                        {
                            new File { Name = "@feature.reducer.ts", Content = "import { createReducer, on } from '@ngrx/store';\r\nimport * as actions from '../actions';\r\n\r\nimport {\r\n  HttpResponseError\r\n} from 'src/app/core';\r\n\r\nimport {\r\n  @entity\r\n} from 'src/app/domain';\r\n\r\n\r\nexport const @fEATUREFeatureKey = '@fEATURE';\r\nexport const @fEATURERoute = '@feature';\r\n\r\nexport interface @entityState {\r\n  itens: @entity[];\r\n  isLoading: boolean;\r\n  isLoadingSuccess: boolean;\r\n  isLoadingFailure: boolean;\r\n  error: HttpResponseError | undefined;\r\n}\r\n\r\nexport const @fEATUREInitialState: @entityState = {\r\n  itens: [],\r\n  isLoading: false,\r\n  isLoadingSuccess: false,\r\n  isLoadingFailure: false,\r\n  error: undefined\r\n};\r\n\r\nexport const @fEATUREReducer = createReducer(\r\n  @fEATUREInitialState,\r\n\r\n  on(actions.selecionar@entity, state => {\r\n    return {\r\n      ...state,\r\n      isLoading: true,\r\n      isLoadingSuccess: false,\r\n      isLoadingFailure: false,\r\n      error: undefined\r\n    };\r\n  }),\r\n  on(actions.selecionar@entitySuccess, (state, action) => {\r\n    let itens = [...action.response].map(item => @entity.create(item));\r\n\r\n    return {\r\n      ...state,\r\n      itens: itens,\r\n      isLoading: false,\r\n      isLoadingSuccess: true,\r\n      isLoadingFailure: false,\r\n      error: undefined\r\n    };\r\n  }),\r\n  on(actions.selecionar@entityFailure, (state, action) => {\r\n    return {\r\n      ...state,\r\n      isLoading: false,\r\n      isLoadingSuccess: true,\r\n      isLoadingFailure: false,\r\n      error: action.error\r\n    };\r\n  })\r\n);\r\n" },
                            new File { Name = "index.ts", Content = "export * from './@feature.reducer';" }
                        }
                    },
                    new Directory
                    {
                        Path = "selectors",
                        Files = new List<File>()
                        {
                            new File { Name = "@feature.selectors.ts", Content = "import { createFeatureSelector, createSelector } from '@ngrx/store';\r\n\r\nimport {\r\n  @entity\r\n} from 'src/app/domain'\r\n\r\nimport * as from@entity from '../reducers';\r\n\r\nexport const getOne@entityState = createFeatureSelector<from@entity.@entityState>(\r\n  from@entity.@fEATUREFeatureKey\r\n);\r\n\r\nexport const getMany@entity = createSelector(\r\n  getOne@entityState, (\r\n    state\r\n  ): @entity[] => {\r\n\r\n  return state.itens;\r\n});\r\n" },
                            new File { Name = "index.ts", Content = "export * from './@feature.selectors';" }
                        }
                    }
                }
            }
        };

        public static void CreateFeature
        (
            string folder,
            string entity
        )
        {
            string feauture = GetFeature(entity);
            foreach (Directory directory in directories)
                directory
                    .Create
                    (
                        folder,
                        feauture,
                        entity,
                        feauture
                    );
        }

        private static string GetFeature(string entity)
        {
            string feature = "";

            foreach (string s in Regex.Split(entity, @"(?<!^)(?=[A-Z])"))
                feature += "-" + s.ToLower();

            return feature.Substring(1);
        }
    }
}
