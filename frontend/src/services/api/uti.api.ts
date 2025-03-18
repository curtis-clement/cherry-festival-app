import { InvalidUuidError, isUuid } from '@/utils';

export class QueryBuilder {
  private query: string[] = [];

  public addQueryArgument(key: string, value?: string): this {
    const queryEqualsSign: string = '=';
    const queryString: string = `${key}${queryEqualsSign}${value}`;

    if (!value || value === '') {
      return this;
    }

    this.query.push(queryString);
    return this;
  }

  public build(): string {
    const queryStartSign: string = '?';
    const queryConcatSign: string = '&';

    if (this.query.length === 0) {
      return '';
    }

    return `${queryStartSign}${this.query.join(queryConcatSign)}`;
  }
}

export class PathBuilder {
  private path: string = '';
  private delimiter: string = '/';
  private queryBuilder: QueryBuilder = new QueryBuilder();

  public addString(str: string): this {
    this.path += `${this.delimiter}${str}`;
    return this;
  }

  public addId(id: string): this {
    if (!isUuid(id)) {
      throw new InvalidUuidError(`Invalid UUID was provided: ${id}`);
    }

    return this.addString(id);
  }

  public addQueryArgument(key: string, value?: string): this {
    this.queryBuilder.addQueryArgument(key, value);
    return this;
  }

  public build(): string {
    return this.path + this.queryBuilder.build();
  }
}