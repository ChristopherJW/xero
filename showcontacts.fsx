
#load "settings.fsx"
open Xero.Api.Core
open Xero.Api.Serialization

open Xero.Api.Core.Model


let api = new XeroCoreApi(Settings.BaseUrl,Settings.Authenticator,Settings.Consumer,null,new DefaultMapper(),new DefaultMapper())

api.Contacts.Find() 
    |> Seq.iter(fun f -> printf "%s\n" f.Name)

