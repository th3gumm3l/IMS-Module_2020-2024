<template>
    <ul class="people">
        <li v-for="index in 10" :key="index" class="person">
            <img class="person__image" src="https://source.unsplash.com/300x300/?portrait"/>
            <div class="person__inner">
                <div class="person__title">
                    Andi Moser
                </div>
                <div class="person__text">
                    Web Entwickler
                </div>
                <button class="person__button">Kontaktieren</button>
            </div>
        </li>
    </ul>
</template>
<style lang="scss">
    .people {
        display: grid;
        grid-template-columns: 1fr 1fr 1fr;
        gap: 10px;
        list-style-type: none;

    .person {
        margin-bottom: 40px;
        &__image {
          border-radius: 50%;
          width: 100%;
        }

        &__inner {
          text-align: center;
        }

        &__title {
          font-size: 2rem;
          font-weight: bold;
        }

        &__button {
          background-color: teal;
          border-radius: 5px;
          color: white;
          padding: 10px;
          border: none;
          margin: 30px 0 0;
        }
    }
}

@media only screen and (max-width: 768px) {
    .people {
        grid-template-columns: 1fr 1fr;

        .person {
          display: flex;
        }

        &__image {
          width: 50%;
        }

        &__title {
          font-size: 1.5rem;
        }

        &__button {
          margin: 5px 0 0;
        }

        &__inner {
          padding-top: 25px;
        }
    }
}

@media only screen and (max-width: 550px) {
    .people {
        grid-template-columns: 1fr;
        padding: 0;

        .person {
          flex-direction: column;
          align-items: center;
        }
    }
}
</style>