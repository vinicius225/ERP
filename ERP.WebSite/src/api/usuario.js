export default ({ instance }) => 
{ const apiCalls = 
    { autenticar(usuario) 
        { return instance(
            { method: "post", 
            url: "autenticacao/logarW",
             data: usuario, }); 
    }, };
         return apiCalls; };