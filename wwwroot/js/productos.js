document.addEventListener('DOMContentLoaded', function () {
    const buscador = document.getElementById('buscadorProducto');
    const filas = document.querySelectorAll('#tablaProductos tbody tr');

    // 🔍 Buscar productos en la tabla de la modal
    buscador.addEventListener('keyup', function () {
        const filtro = buscador.value.toLowerCase();

        filas.forEach(fila => {
            const nombre = fila.querySelector('td').textContent.toLowerCase();
            fila.style.display = nombre.includes(filtro) ? '' : 'none';
        });
    });

    // ✅ Evento para seleccionar producto y pasarlo a la tabla principal
    const botonesSeleccionar = document.querySelectorAll('.seleccionar-producto');
    const tablaPrincipal = document.querySelector('#tablaPrincipal tbody');

    botonesSeleccionar.forEach(boton => {
        boton.addEventListener('click', function () {
            const nombre = this.dataset.nombre;
            const presentacion = this.dataset.presentacion;
            const codigo = this.dataset.codigo;

            const fila = `
                <tr>
                    <td>${nombre}</td>
                    <td>${presentacion}</td>
                    <td>${codigo}</td>
                </tr>
            `;
            tablaPrincipal.insertAdjacentHTML('beforeend', fila);

            // Cerrar modal automáticamente (opcional)
            const modal = bootstrap.Modal.getInstance(document.getElementById('modalProductos'));
            modal.hide();
        });
    });
});
