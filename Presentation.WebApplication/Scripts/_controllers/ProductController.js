(function () {
    'use strict'
    app.controller('ProductController', Controller);

    function Controller($scope, ProductService) {

        $scope.productos = [];

        var _this = this;

        initController();

        function initController(){
        }



        this.Load = {
            loadDataTable: function (products) {

                var table = $("#table-pruebita").DataTable({
                    lengthChange: false,
                    data: products,
                    searching: false,
                    lengthMenu: [3],
                    select: true,
                    columns: [
                        { data: 'id' },
                        { data: 'descripcion' },
                        { data: 'tipo' },
                        { data: 'marca' },
                        {
                            data: 'fechaRegistro',
                            render: function (jsonDate) {
                                var date = new Date(parseInt(jsonDate.replace('/Date(', '')))
                                var newDate = date.toISOString();
                                return newDate;
                            }
                        },
                        { data: 'estado' }
                    ],
                    "pagingType": "full_numbers",
                    order: [[0, 'desc']],
                    "dom": '<"topcustom"lfr>t<"bottomcustom"ip>',
                });


                table.on('dblclick', 'tr', function () {
                    debugger;
                    var data = table.row(this).data();
                    alert('You clicked on ' + data.descripcion + '\'s row');
                })
            },
            loadRemoteData: function () {
                ProductService.getProducts()
                    .then((products) => {
                        this.applyRemoteData(products);
                    });
            },
            applyRemoteData: function (products) {
                $scope.productos = products;

                _this.Load.loadDataTable(products);
            }
        };
        var _constructor = function () {
            _this.Load.loadRemoteData();
        }()
    };


})();
