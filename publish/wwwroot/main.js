

async function test() {
    const response = await fetch('./api/home/get')
  
    if (response.status === 200) {
        const r = await response.json();

        document.querySelector('#data').innerHTML = JSON.stringify(r);
    }
}

async function users() {
    const response = await fetch('./api/home/users')
  
    if (response.status === 200) {
        const r = await response.json();

        document.querySelector('#users').innerHTML = JSON.stringify(r);
    }
}

test();
users();