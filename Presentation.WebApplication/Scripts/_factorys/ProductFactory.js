(function () {

    app.factory('ProductFactory', Factory);

    function Factory(ProductService) {

        var factory = {};

        factory.handleSuccess = handleSuccess;
        factory.handleError = handleError;


        return factory;




        function handleSuccess(response) {
            return (response.data);
        }

        function handleError(response) {

            if (
                !angular.isObject(response.data) ||
                !response.data.message
            ) {
                return ($q.reject("An unknown error occurred."));
            }
            // Otherwise, use expected error message.
            return ($q.reject(response.data.message));
        }

        function loadProductsTable () {
            ProductService.getProducts()
                .then((products) => {
                    this.applyRemoteData(products);
                });
        }

        function applyRemoteData(products) {
            $scope.productos = products;
            _this.Load.loadDataTable(products);
        }

    }
})();