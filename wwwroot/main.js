

async function main() {
    const response = await fetch('./api/home/get')
  
    if (response.status === 200) {
    console.log(response.json())
    }
}

main();