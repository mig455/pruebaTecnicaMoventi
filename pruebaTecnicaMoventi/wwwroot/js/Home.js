document.addEventListener('DOMContentLoaded', async () => {
    const countrySelect = document.getElementById('country');
    const resultsDiv = document.getElementById('results');
    const Docuents = []
    try {
        const response = await fetch('/api/DocumentType');
        const data = await response.json();

        const countryMap = new Map();
        data.forEach(item => {
            countryMap.set(item.nombrePais, item.documentos);
        });

        data.forEach((country) => {
            const option = document.createElement('option');
            option.value = country.id;
            option.textContent = country.nombrePais;
            countrySelect.appendChild(option);
        });
        console.log(document.getElementById('country').value)
        fetchDocumentTypesByCountry(document.getElementById('country').value)
        document.getElementById('documentForm').addEventListener('submit', (event) => {
            event.preventDefault();

            Resultados(document.getElementById('numberDocument').value)
            
        });
    } catch (error) {
        console.error('Error fetching document types:', error);
        resultsDiv.innerHTML += '<p>Ocurrió un error al buscar los tipos de documentos. Por favor, intente de nuevo más tarde.</p>';
    }
});
async function fetchDocumentTypes() {
    try {
        const response = await fetch('/api/DocumentType');
        const data = await response.json();
        console.log(data);
    } catch (error) {
        console.error('Error fetching document types:', error);
    }
}
function changeCountry(){
    console.log(document.getElementById('country').value)
    fetchDocumentTypesByCountry(document.getElementById('country').value)
}
function changeDocuement() {
    console.log(Docuents)
    var d=Docuents[document.getElementById('typeDocument').value]
    document.getElementById('numberDocument').value = ''
    document.getElementById('numberDocument').type = 'number';
    if (d.esAlfanumerico == true) {
        document.getElementById('numberDocument').type = 'text';
    }
    //numberDocument
}
function changeDocuementNumber() {
    var data = document.getElementById('numberDocument').value
    var d = Docuents[document.getElementById('typeDocument').value]
    document.getElementById('errornumberDocument').hidden = false;
    if (data.length < d.longitudMinima) {

        document.getElementById('botonFiltrar').setAttribute('disabled', "true");
        document.getElementById('numberDocument').classList.add("inputerror")
        document.getElementById('msjError').innerHTML = 'El documento debe tener minimo ' + d.longitudMinima + ' digitos.';
        return;
    }
    if (data.length > d.longitudMaxima) {
        document.getElementById('botonFiltrar').setAttribute('disabled', "true");
        document.getElementById('numberDocument').classList.add("inputerror")
        document.getElementById('msjError').innerHTML = 'El documento debe tener maximo ' + d.longitudMaxima + ' digitos.';
        return;
    }
    document.getElementById('botonFiltrar').removeAttribute('disabled')
    document.getElementById('numberDocument').classList.remove("inputerror")
    document.getElementById('errornumberDocument').hidden = true;
    console.log(d)
}

async function fetchDocumentTypesByCountry(id) {
    try {
        const response = await fetch(`/api/DocumentType/${id}`);
        const data = await response.json();
        var typeDocument = document.getElementById('typeDocument')
        console.log(data);
        Docuents = data.documentos;
        for (let i = typeDocument.options.length; i >= 0; i--) {
            typeDocument.remove(i);
        }
        //typeDocument.removeChild();
        data.documentos.forEach((doc,index) => {
            const option = document.createElement('option');
            option.value = index;
            option.textContent = doc.nombre;
            typeDocument.appendChild(option);
        });
        this.changeDocuement()
    } catch (error) {
        console.error('Error fetching document types by country:', error);
    }
}
async function Resultados(doc) {
    try {
        const response = await fetch(`/api/ClientScore/${doc}`);
        var nivelResult = document.getElementById('nivelResult')
        var radomData = document.getElementById('radomData')
        var horaData = document.getElementById('horaData')
        var tipoDData = document.getElementById('tipoDData')
        var nombreData = document.getElementById('nombreData')
        var NumeroDData = document.getElementById('NumeroDData')
        var cardResult = document.getElementById('cardResult')
        var titleResult = document.getElementById('titleResult')
        var paso1 = document.getElementById('paso1')
        var paso2 = document.getElementById('paso2')
        paso1.hidden = true
        paso2.hidden = false
        //
        //
        
        var d = Docuents[document.getElementById('typeDocument').value]
        tipoDData.innerHTML = d.nombre
        NumeroDData.innerHTML = document.getElementById('numberDocument').value
        document.getElementById('textHeader').innerHTML = 'Resultados de precalificación'
        radomData.innerHTML = Math.floor(10000000 + Math.random() * 90000000)
        horaData.innerHTML = obtenerHoraActualFormateada();
        if (!response.ok) {
            cardResult.classList.add('clienteSinEscore')
            titleResult.innerHTML = " Usuario Sin Score";
            nivelResult.innerHTML = "-";
            nombreData.innerHTML = "-";
            return;
        }
       
        const data = await response.json();
        console.log(data);
        nivelResult.innerHTML = data.score;
        nombreData.innerHTML = data.nombre;
        console.log(esDeLaAlaG(data.score.toLowerCase()));
        if (esDeLaAlaG(data.score.toLowerCase())) {
            cardResult.classList.add('clienteCalifica')
            titleResult.innerHTML = " El cliente pre-califica";
            return;
        }
        cardResult.classList.add('clienteNoCalifica')
        titleResult.innerHTML = " El cliente no califica";
    } catch (error) {
        console.error('Error fetching document types by country:', error);
    }
}
function esDeLaAlaG(valor) {
    const regex = /^[a-g]$/;
    return regex.test(valor);
}
function obtenerHoraActualFormateada() {
    const date = new Date();

    let hours = date.getHours();
    const minutes = date.getMinutes();
    const ampm = hours >= 12 ? 'pm' : 'am';

    hours = hours % 12;
    hours = hours ? hours : 12; 
    const minutesStr = minutes < 10 ? '0' + minutes : minutes;

    return `${hours}:${minutesStr} ${ampm}`;
}